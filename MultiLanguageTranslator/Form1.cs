using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiLanguageTranslator
{
    public partial class Form1 : Form
    {
        // Çeviri sözlüğü
        private readonly Dictionary<string, string> _translations =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public Form1()
        {
            InitializeComponent();
            LoadLanguages();
            LoadDictionary();
        }

        private void LoadLanguages()
        {
            // Combobox'a diller ekleniyor
            cmbSourceLang.Items.Add("Türkçe (tr)");
            cmbSourceLang.Items.Add("İngilizce (en)");
            cmbSourceLang.Items.Add("Almanca (de)");
            cmbSourceLang.Items.Add("Fransızca (fr)");

            cmbTargetLang.Items.Add("Türkçe (tr)");
            cmbTargetLang.Items.Add("İngilizce (en)");
            cmbTargetLang.Items.Add("Almanca (de)");
            cmbTargetLang.Items.Add("Fransızca (fr)");

            // Varsayılan seçimler
            cmbSourceLang.SelectedIndex = 0; // Türkçe
            cmbTargetLang.SelectedIndex = 1; // İngilizce
        }

        private string GetLangCode(string text)
        {
            if (text == null)
                return null;

            if (text.Contains("(tr)")) return "tr";
            if (text.Contains("(en)")) return "en";
            if (text.Contains("(de)")) return "de";
            if (text.Contains("(fr)")) return "fr";

            return null;
        }

        // ==== BURASI ÇOKLU DİL SÖZLÜĞÜ ====
        private void LoadDictionary()
        {
            // -----------------------------
            // TÜRKÇE ↔ İNGİLİZCE
            // -----------------------------
            Add("tr", "en", "merhaba", "hello");
            Add("en", "tr", "hello", "merhaba");

            Add("tr", "en", "kitap", "book");
            Add("en", "tr", "book", "kitap");

            Add("tr", "en", "araba", "car");
            Add("en", "tr", "car", "araba");

            Add("tr", "en", "ev", "house");
            Add("en", "tr", "house", "ev");

            Add("tr", "en", "su", "water");
            Add("en", "tr", "water", "su");

            Add("tr", "en", "gülmek", "smile");
            Add("en", "tr", "smile", "gülmek");

            Add("tr", "en", "mutlu", "happy");
            Add("en", "tr", "happy", "mutlu");

            Add("tr", "en", "yemek", "food");
            Add("en", "tr", "food", "yemek");

            Add("tr", "en", "hava", "weather");
            Add("en", "tr", "weather", "hava");

            Add("tr", "en", "telefon", "phone");
            Add("en", "tr", "phone", "telefon");

            Add("tr", "en", "bilgisayar", "computer");
            Add("en", "tr", "computer", "bilgisayar");

            Add("tr", "en", "okul", "school");
            Add("en", "tr", "school", "okul");

            Add("tr", "en", "öğrenci", "student");
            Add("en", "tr", "student", "öğrenci");

            Add("tr", "en", "çalışmak", "work");
            Add("en", "tr", "work", "çalışmak");

            Add("tr", "en", "uyumak", "sleep");
            Add("en", "tr", "sleep", "uyumak");

            Add("tr", "en", "yürümek", "walk");
            Add("en", "tr", "walk", "yürümek");

            Add("tr", "en", "koşmak", "run");
            Add("en", "tr", "run", "koşmak");

            Add("tr", "en", "yazmak", "write");
            Add("en", "tr", "write", "yazmak");

            Add("tr", "en", "okumak", "read");
            Add("en", "tr", "read", "okumak");

            Add("tr", "en", "dinlemek", "listen");
            Add("en", "tr", "listen", "dinlemek");

            Add("tr", "en", "izlemek", "watch");
            Add("en", "tr", "watch", "izlemek");

            Add("tr", "en", "bilmek", "know");
            Add("en", "tr", "know", "bilmek");

            Add("tr", "en", "anlamak", "understand");
            Add("en", "tr", "understand", "anlamak");

            Add("tr", "en", "istemek", "want");
            Add("en", "tr", "want", "istemek");

            Add("tr", "en", "sevmek", "love");
            Add("en", "tr", "love", "sevmek");

            Add("tr", "en", "nefret etmek", "hate");
            Add("en", "tr", "hate", "nefret etmek");

            Add("tr", "en", "para", "money");
            Add("en", "tr", "money", "para");

            Add("tr", "en", "zaman", "time");
            Add("en", "tr", "time", "zaman");

            Add("tr", "en", "oyun", "game");
            Add("en", "tr", "game", "oyun");

            Add("tr", "en", "film", "movie");
            Add("en", "tr", "movie", "film");

            Add("tr", "en", "müzik", "music");
            Add("en", "tr", "music", "müzik");

            Add("tr", "en", "resim", "picture");
            Add("en", "tr", "picture", "resim");

            Add("tr", "en", "sanat", "art");
            Add("en", "tr", "art", "sanat");

            Add("tr", "en", "spor", "sport");
            Add("en", "tr", "sport", "spor");

            Add("tr", "en", "sağlık", "health");
            Add("en", "tr", "health", "sağlık");

            Add("tr", "en", "doktor", "doctor");
            Add("en", "tr", "doctor", "doktor");

            Add("tr", "en", "ilaç", "medicine");
            Add("en", "tr", "medicine", "ilaç");

            Add("tr", "en", "hastane", "hospital");
            Add("en", "tr", "hospital", "hastane");

            Add("tr", "en", "alışveriş", "shopping");
            Add("en", "tr", "shopping", "alışveriş");

            Add("tr", "en", "hediye", "gift");
            Add("en", "tr", "gift", "hediye");

            Add("tr", "en", "mutfak", "kitchen");
            Add("en", "tr", "kitchen", "mutfak");

            Add("tr", "en", "oda", "room");
            Add("en", "tr", "room", "oda");

            // -----------------------------
            // TÜRKÇE ↔ ALMANCA
            // -----------------------------
            Add("tr", "de", "merhaba", "hallo");
            Add("de", "tr", "hallo", "merhaba");

            Add("tr", "de", "araba", "Auto");
            Add("de", "tr", "Auto", "araba");

            Add("tr", "de", "ev", "Haus");
            Add("de", "tr", "Haus", "ev");

            Add("tr", "de", "okul", "Schule");
            Add("de", "tr", "Schule", "okul");

            Add("tr", "de", "öğrenci", "Student");
            Add("de", "tr", "Student", "öğrenci");

            Add("tr", "de", "kitap", "Buch");
            Add("de", "tr", "Buch", "kitap");

            // -----------------------------
            // TÜRKÇE ↔ FRANSIZCA
            // -----------------------------
            Add("tr", "fr", "merhaba", "bonjour");
            Add("fr", "tr", "bonjour", "merhaba");

            Add("tr", "fr", "araba", "voiture");
            Add("fr", "tr", "voiture", "araba");

            Add("tr", "fr", "ev", "maison");
            Add("fr", "tr", "maison", "ev");

            Add("tr", "fr", "okul", "école");
            Add("fr", "tr", "école", "okul");

            Add("tr", "fr", "öğrenci", "étudiant");
            Add("fr", "tr", "étudiant", "öğrenci");

            Add("tr", "fr", "kitap", "livre");
            Add("fr", "tr", "livre", "kitap");

            // -----------------------------
            // İNGİLİZCE ↔ ALMANCA
            // -----------------------------
            Add("en", "de", "hello", "hallo");
            Add("de", "en", "hallo", "hello");

            Add("en", "de", "car", "Auto");
            Add("de", "en", "Auto", "car");

            Add("en", "de", "house", "Haus");
            Add("de", "en", "Haus", "house");

            Add("en", "de", "book", "Buch");
            Add("de", "en", "Buch", "book");

            Add("en", "de", "school", "Schule");
            Add("de", "en", "Schule", "school");

            // -----------------------------
            // İNGİLİZCE ↔ FRANSIZCA
            // -----------------------------
            Add("en", "fr", "hello", "bonjour");
            Add("fr", "en", "bonjour", "hello");

            Add("en", "fr", "car", "voiture");
            Add("fr", "en", "voiture", "car");

            Add("en", "fr", "house", "maison");
            Add("fr", "en", "maison", "house");

            Add("en", "fr", "book", "livre");
            Add("fr", "en", "livre", "book");

            Add("en", "fr", "school", "école");
            Add("fr", "en", "école", "school");
        }

        private void Add(string sourceLang, string targetLang, string sourceText, string targetText)
        {
            string key = BuildKey(sourceLang, targetLang, sourceText);

            if (!_translations.ContainsKey(key))
            {
                _translations.Add(key, targetText);
            }
        }

        private string BuildKey(string sourceLang, string targetLang, string sourceText)
        {
            return $"{sourceLang}|{targetLang}|{sourceText.Trim().ToLower()}";
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (cmbSourceLang.SelectedItem == null || cmbTargetLang.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kaynak ve hedef dili seç.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sourceLang = GetLangCode(cmbSourceLang.SelectedItem.ToString());
            string targetLang = GetLangCode(cmbTargetLang.SelectedItem.ToString());

            if (sourceLang == null || targetLang == null)
            {
                MessageBox.Show("Dil kodu okunamadı.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sourceLang == targetLang)
            {
                MessageBox.Show("Kaynak ve hedef dil aynı olamaz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = txtInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Lütfen çevirmek istediğin kelime veya ifadeyi yaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string key = BuildKey(sourceLang, targetLang, input);

            if (_translations.TryGetValue(key, out string result))
            {
                txtOutput.Text = result;
            }
            else
            {
                txtOutput.Text = "Bu ifade sözlükte bulunamadı :(";
            }
        }
    }
}
