// FavoriteCardViewManager.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ЗнижкоСвіт
{
    public class FavoriteCardUI 
    {
        private TableLayoutPanel tableLayoutPanel;
        private FavoriteManager favoriteCardManager;

        public FavoriteCardUI(TableLayoutPanel tableLayoutPanel, FavoriteManager favoriteCardManager)
        {
            this.tableLayoutPanel = tableLayoutPanel;
            this.favoriteCardManager = favoriteCardManager;
            UpdateTableLayoutPanel();
        }

        public void UpdateTableLayoutPanel()
        {
            tableLayoutPanel.Controls.Clear();
            var favoriteCards = favoriteCardManager.GetCards();
            tableLayoutPanel.RowCount = (int)Math.Ceiling(favoriteCards.Count / 3.0);
            tableLayoutPanel.ColumnCount = 3;

            for (int i = 0; i < favoriteCards.Count; i++)
            {
                var cardControl = CreateCardControl(favoriteCards[i]);
                tableLayoutPanel.Controls.Add(cardControl, i % 3, i / 3);
            }
        }

        private Control CreateCardControl(Card card)
        {
            var panel = new Panel
            {
                Size = new Size(550, 450),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(25),
                BackColor = ThemeManager.CurrentTheme == 1 ? ColorTranslator.FromHtml("#e1d9ce") : Color.White
            };

            var pictureBox = new PictureBox
            {
                ImageLocation = card.ImagePath,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(400, 230),
                Location = new Point(0, 0)
            };

            try
            {
                pictureBox.Image = Image.FromFile(card.ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }

            var nameLabel = new Label
            {
                Text = card.Name,
                AutoSize = false,
                Location = new Point(10, 230),
                Font = new Font("Montserrat", 13, FontStyle.Bold),
                MaximumSize = new Size(360, 0),
                Width = 360,
                Height = 80
            };

            var descriptionLabel = new Label
            {
                Text = card.Address,
                AutoSize = true,
                Location = new Point(10, 310),
                Font = new Font("Montserrat", 12),
                ForeColor = Color.DimGray
            };

            var priceLabel = new Label
            {
                Text = $"{card.Price}",
                AutoSize = true,
                Location = GetPriceLocation(card),
                Font = new Font("Montserrat", 14, FontStyle.Strikeout | FontStyle.Bold),
                ForeColor = Color.Gray
            };

            var discountLabel = new Label
            {
                Text = $"{card.Discount} грн",
                AutoSize = true,
                Location = GetDiscountLocation(card),
                Font = new Font("Montserrat", 19, FontStyle.Bold),
                ForeColor = Color.Red
            };

            var favoritePictureBox = new PictureBox
            {
                Image = Image.FromFile("Images/Heart.png"),
                Location = new Point(20, 390),
                Size = new Size(40, 40),
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand
            };

            favoritePictureBox.MouseEnter += (sender, e) =>
            {
                favoritePictureBox.Image = Image.FromFile("Images/EmptyHeart.png");
            };

            favoritePictureBox.MouseLeave += (sender, e) =>
            {
                favoritePictureBox.Image = Image.FromFile("Images/Heart.png");
            };

            favoritePictureBox.Click += (sender, e) =>
            {
                favoriteCardManager.RemoveCardFromFavorites(card);
                MessageBox.Show($"{card.Name} removed from favorites.");
                UpdateTableLayoutPanel();
            };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(descriptionLabel);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(discountLabel);
            panel.Controls.Add(favoritePictureBox);

            return panel;
        }

        private Point GetPriceLocation(Card card)
        {
            if (card.Price < 100 && card.Discount < 100) return new Point(215, 400);
            if (card.Price >= 100 && card.Discount < 100) return new Point(215, 400);
            if (card.Price > 999 && card.Discount < 999) return new Point(185, 400);
            if (card.Price > 999 && card.Discount > 999) return new Point(170, 400);
            return new Point(205, 400);
        }

        private Point GetDiscountLocation(Card card)
        {
            if (card.Price < 100 && card.Discount < 100) return new Point(250, 393);
            if (card.Price >= 100 && card.Discount < 100) return new Point(260, 393);
            if (card.Price > 999 && card.Discount < 999) return new Point(243, 393);
            if (card.Price > 999 && card.Discount > 999) return new Point(230, 393);
            return new Point(250, 393);
        }
    }
}
