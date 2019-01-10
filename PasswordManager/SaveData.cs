﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace PasswordManager {
    public class SaveData {
        public string Path;
        public bool IsEmpty { get => RawData.Length == 0; }

        private byte[] RawData;
        private Data Data = new Data();
        public SaveData(string path) {
            Path = path;
            RawData = File.Exists(path) ? File.ReadAllBytes(path) : new byte[0];
            Data = new Data();
            Data.Elements = new List<Data.Item>();
        }

        public bool TryParse(byte[] master) {
            if (IsEmpty) return false;
            try {
                var json = RawData.DecryptToString(master);
                Data = JsonConvert.DeserializeObject<Data>(json);
                return true;
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ex.Source);
                return false;
            }
        }

        public void Encode(byte[] master) {
            var json = JsonConvert.SerializeObject(Data);
            RawData = json.EncryptBytes(master);
        }

        public void Save() {
            if (IsEmpty) return;
            File.WriteAllBytes(Path, RawData);
        }

        public PasswordElement[] GetElements(byte[] master) {
            var passwords = new PasswordElement[Data.Elements.Count];
            for (int i = 0; i < Data.Elements.Count; i++) {
                var item = Data.Elements[i];
                passwords[i] = new PasswordElement(item.Name.DecryptToString(master), item.Password.DecryptToString(master), master, item.IconData.GetImage());
            }
            return passwords;
        }

        public void SetElements(PasswordElement[] elements, byte[] master) {
            Data.Elements = new List<Data.Item>();
            foreach(var item in elements) {
                Data.Elements.Add(new Data.Item {
                    Name = item.NameTag.Text.EncryptBytes(master),
                    Password = item.EncryptedPassword,
                    IconData = item.HasIcon ? item.icon.Image.GetBytes() : null
                });
            }
        }
    }
    
    public struct Data {
        public List<Item> Elements { get; set; }

        public struct Item {
            public byte[] Name { get; set; }
            public byte[] Password { get; set; }
            public byte[] IconData { get; set; }
        }
    }
}
