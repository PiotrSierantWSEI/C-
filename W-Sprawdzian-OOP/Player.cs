using System;
using System.Collections.Generic;
public class Player
    {
        private string _name;
        private string _password;
        private int _bestScore;
        private int _lastScore;

        public string Name
        {
            get => _name;
            set
            {
                string formattedValue = value.ToLower().Trim();

                formattedValue = formattedValue.Replace(" ", "");

                if (string.IsNullOrEmpty(formattedValue) || ContainsNonLetterOrDigit(formattedValue))
                {
                    throw new ArgumentException("Wrong name!");
                }

                if (formattedValue.Length < 3)
                {
                    throw new ArgumentException("Wrong name!");
                }

                if (!char.IsLetter(formattedValue[0]))
                {
                    throw new ArgumentException("Wrong name!");
                }

                _name = formattedValue;
            }
        }

        public int BestScore
        {
            get => _bestScore;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Wrong score!");
                }
                _bestScore = value;
            }
        }
        public int LastScore
        {
            get => _lastScore;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Wrong score!");
                }
                _lastScore = value;
            }
        }

        public double AvgScore { get; private set; }

        private List<int> Scores { get; } = new List<int>();

        /* Konstruktor */
        public Player(string name, string password)
        {
            Name = name;

            if (!IsValidPassword(password)) throw new ArgumentException("Wrong password!");
            _password = password;

            BestScore = 0;
            LastScore = 0;
            AvgScore = 0;
        }

        static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password) || password.Length < 8 || password.Length > 16)
            {
                return false;
            }

            bool hasUpper = false, hasLower = false, hasDigit = false, hasPunctuation = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
                if (char.IsPunctuation(c)) hasPunctuation = true;

                if (hasUpper && hasLower && hasDigit && hasPunctuation)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ContainsNonLetterOrDigit(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetterOrDigit(c)) return true;
            }

            return false;
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == _password)
            {
                if (IsValidPassword(newPassword))
                {
                    _password = newPassword;
                    return true;
                }
            }
            return false;
        }

        public bool VerifyPassword(string password)
        {
            return password == _password;
        }

        public bool TryAddScore(int currentScore)
        {
            if (currentScore < 0 || currentScore > 100)
            {
                return false;
            }

            LastScore = currentScore;
            if (currentScore > BestScore)
            {
                BestScore = currentScore;
            }

            Scores.Add(currentScore);
            UpdateAverageScore();

            return true;
        }

        public void AddScore(int currentScore)
        {
            if (currentScore < 0 || currentScore > 100)
            {
                throw new ArgumentOutOfRangeException(null, "Wrong value!");
            }

            LastScore = currentScore;
            if (currentScore > BestScore)
            {
                BestScore = currentScore;
            }

            Scores.Add(currentScore);
            UpdateAverageScore();
        }

            private void UpdateAverageScore()
        {
            int sum = 0;
            foreach (int score in Scores)
            {
                sum += score;
            }

            AvgScore = Scores.Count > 0 ? (double)sum / Scores.Count : 0;
        }

         public override string ToString()
        {
            var avg = AvgScore == 0 ? 0 : Math.Round(AvgScore, 1);
            return $"Name: {Name}, Score: last={LastScore}, best={BestScore}, avg={avg}";
        }
    }