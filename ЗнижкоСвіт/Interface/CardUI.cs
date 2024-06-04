using System;
using System.Drawing;
using System.Windows.Forms;
using ЗнижкоСвіт;

public class CardUI 
{
    private TableLayoutPanel tableLayoutPanel;
    private CardManager cardManager;

    public CardUI(TableLayoutPanel tableLayoutPanel, CardManager cardManager)
    {
        this.tableLayoutPanel = tableLayoutPanel;
        this.cardManager = cardManager;
    }

    public void AddCard(Card card)
    {
        cardManager.AddCard(card);
        UpdateTableLayoutPanel();
    }

    public void RemoveCard(Card card)
    {
        cardManager.RemoveCard(card);
        UpdateTableLayoutPanel();
    }

    public void UpdateTableLayoutPanel()
    {
        tableLayoutPanel.Controls.Clear();
        var cards = cardManager.GetCards();
        tableLayoutPanel.RowCount = (int)Math.Ceiling(cards.Count / 3.0);
        tableLayoutPanel.ColumnCount = 3;

        for (int i = 0; i < cards.Count; i++)
        {
            var cardControl = CreateCardControl(cards[i]);
            tableLayoutPanel.Controls.Add(cardControl, i % 3, i / 3);
        }
    }

    private Control CreateCardControl(Card card)
    {
        var panel = new Panel
        {
            Size = new System.Drawing.Size(550, 450),
            BorderStyle = BorderStyle.FixedSingle,
            Margin = new Padding(25)
        };

        if (ThemeManager.CurrentTheme == 1)
        {
            panel.BackColor = ColorTranslator.FromHtml("#e1d9ce");
        }
        else
        {
            panel.BackColor = Color.White;
        }

        var pictureBox = new PictureBox
        {
            ImageLocation = card.ImagePath,
            Location = new System.Drawing.Point(0, 0),
            SizeMode = PictureBoxSizeMode.Zoom,
            Size = new System.Drawing.Size(400, 230),
        };

        try
        {
            pictureBox.Image = System.Drawing.Image.FromFile(card.ImagePath);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading image: {ex.Message}");
        }

        var nameLabel = new Label
        {
            Text = card.Name,
            AutoSize = false,
            Location = new System.Drawing.Point(10, 230),
            Font = new System.Drawing.Font("Montserrat", 13, System.Drawing.FontStyle.Bold),
            MaximumSize = new Size(360, 0),
            Width = 360,
            Height = 80
        };

        var descriptionLabel = new Label
        {
            Text = card.Address,
            AutoSize = true,
            Location = new System.Drawing.Point(10, 310),
            Font = new System.Drawing.Font("Montserrat", 12),
            ForeColor = Color.DimGray
        };

        Point locationPrice;
        Point locationDiscount;

        if (card.Price < 100 && card.Discount < 100)
        {
            locationPrice = new System.Drawing.Point(215, 400);
            locationDiscount = new System.Drawing.Point(250, 393);
        }
        else if (card.Price >= 100 && card.Discount < 100)
        {
            locationPrice = new System.Drawing.Point(215, 400);
            locationDiscount = new System.Drawing.Point(260, 393);
        }
        else if (card.Price > 999 && card.Discount < 999)
        {
            locationPrice = new System.Drawing.Point(185, 400);
            locationDiscount = new System.Drawing.Point(243, 393);
        }
        else if (card.Price > 999 && card.Discount > 999)
        {
            locationPrice = new System.Drawing.Point(170, 400);
            locationDiscount = new System.Drawing.Point(230, 393);
        }
        else
        {
            locationPrice = new System.Drawing.Point(205, 400);
            locationDiscount = new System.Drawing.Point(250, 393);
        }

        var priceLabel = new Label
        {
            Text = $"{card.Price}",
            AutoSize = true,
            Location = locationPrice,
            Font = new System.Drawing.Font("Montserrat", 14, System.Drawing.FontStyle.Strikeout | System.Drawing.FontStyle.Bold),
            ForeColor = Color.Gray
        };

        var discountLabel = new Label
        {
            Text = $"{card.Discount} грн",
            AutoSize = true,
            Location = locationDiscount,
            Font = new System.Drawing.Font("Montserrat", 19, System.Drawing.FontStyle.Bold),
            ForeColor = System.Drawing.Color.Red
        };

        var favoritePictureBox = new PictureBox
        {
            Image = Image.FromFile(card.IsFavorite ? "Images/Heart.png" : "Images/EmptyHeart.png"),
            Location = new System.Drawing.Point(20, 390),
            Size = new System.Drawing.Size(40, 40),
            SizeMode = PictureBoxSizeMode.Zoom,
            Cursor = Cursors.Hand
        };

        favoritePictureBox.MouseEnter += (sender, e) =>
        {
            favoritePictureBox.Image = Image.FromFile("Images/Heart.png");
        };

        favoritePictureBox.MouseLeave += (sender, e) =>
        {
            if (!card.IsFavorite) favoritePictureBox.Image = Image.FromFile("Images/EmptyHeart.png");
        };

        favoritePictureBox.Click += (sender, e) =>
        {
            try
            {
                cardManager.AddToFavorites(card);
                favoritePictureBox.Image = card.IsFavorite ? Image.FromFile("Images/Heart.png") : Image.FromFile("Images/EmptyHeart.png");
                MessageBox.Show($"{card.Name} added to favorites!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        };

        panel.Controls.Add(pictureBox);
        panel.Controls.Add(nameLabel);
        panel.Controls.Add(descriptionLabel);
        panel.Controls.Add(priceLabel);
        panel.Controls.Add(discountLabel);
        panel.Controls.Add(favoritePictureBox);

        return panel;
    }
}
