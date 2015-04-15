      private void TxtUsuario_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
      {

          var txt = (TextBox)sender;
          txt.Text = CheckRegex(txt.Text, @"[\w\d]");
          txt.CaretIndex = txt.Text.Length;
      }
      //cleans the input from anything but text that matches the parameter
      private static String CheckRegex(string text, string regex)
      {
          var regexResult = Regex.Matches(text, regex);
          return text.Length == regexResult.Count ? text :
              regexResult.Cast<object>().Aggregate("", (current, match) => current + match.ToString());

      }
