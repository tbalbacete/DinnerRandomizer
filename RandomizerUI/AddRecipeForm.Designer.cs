namespace RandomizerUI
{
    partial class AddRecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.existingRecipesListBox = new System.Windows.Forms.ListBox();
            this.existingRecipesLabel = new System.Windows.Forms.Label();
            this.addedIngredientsLabel = new System.Windows.Forms.Label();
            this.addedIngredientsListBox = new System.Windows.Forms.ListBox();
            this.addRecipeHeaderLabel = new System.Windows.Forms.Label();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.availableIngredientsDropDown = new System.Windows.Forms.ComboBox();
            this.availableIngredientsLabel = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // existingRecipesListBox
            // 
            this.existingRecipesListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.existingRecipesListBox.FormattingEnabled = true;
            this.existingRecipesListBox.ItemHeight = 41;
            this.existingRecipesListBox.Location = new System.Drawing.Point(12, 138);
            this.existingRecipesListBox.Name = "existingRecipesListBox";
            this.existingRecipesListBox.Size = new System.Drawing.Size(366, 414);
            this.existingRecipesListBox.TabIndex = 0;
            // 
            // existingRecipesLabel
            // 
            this.existingRecipesLabel.AutoSize = true;
            this.existingRecipesLabel.Location = new System.Drawing.Point(70, 94);
            this.existingRecipesLabel.Name = "existingRecipesLabel";
            this.existingRecipesLabel.Size = new System.Drawing.Size(228, 41);
            this.existingRecipesLabel.TabIndex = 1;
            this.existingRecipesLabel.Text = "Existing Recipes";
            // 
            // addedIngredientsLabel
            // 
            this.addedIngredientsLabel.AutoSize = true;
            this.addedIngredientsLabel.Location = new System.Drawing.Point(851, 94);
            this.addedIngredientsLabel.Name = "addedIngredientsLabel";
            this.addedIngredientsLabel.Size = new System.Drawing.Size(265, 41);
            this.addedIngredientsLabel.TabIndex = 3;
            this.addedIngredientsLabel.Text = "Added Ingredients";
            // 
            // addedIngredientsListBox
            // 
            this.addedIngredientsListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.addedIngredientsListBox.FormattingEnabled = true;
            this.addedIngredientsListBox.ItemHeight = 41;
            this.addedIngredientsListBox.Location = new System.Drawing.Point(793, 138);
            this.addedIngredientsListBox.Name = "addedIngredientsListBox";
            this.addedIngredientsListBox.Size = new System.Drawing.Size(366, 414);
            this.addedIngredientsListBox.TabIndex = 2;
            // 
            // addRecipeHeaderLabel
            // 
            this.addRecipeHeaderLabel.AutoSize = true;
            this.addRecipeHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRecipeHeaderLabel.Location = new System.Drawing.Point(443, 9);
            this.addRecipeHeaderLabel.Name = "addRecipeHeaderLabel";
            this.addRecipeHeaderLabel.Size = new System.Drawing.Size(291, 50);
            this.addRecipeHeaderLabel.TabIndex = 4;
            this.addRecipeHeaderLabel.Text = "Add New Recipe";
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.BackColor = System.Drawing.SystemColors.Menu;
            this.addRecipeButton.ForeColor = System.Drawing.Color.Black;
            this.addRecipeButton.Location = new System.Drawing.Point(429, 470);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(319, 81);
            this.addRecipeButton.TabIndex = 6;
            this.addRecipeButton.Text = "Add Recipe";
            this.addRecipeButton.UseVisualStyleBackColor = false;
            // 
            // availableIngredientsDropDown
            // 
            this.availableIngredientsDropDown.FormattingEnabled = true;
            this.availableIngredientsDropDown.Location = new System.Drawing.Point(429, 210);
            this.availableIngredientsDropDown.Name = "availableIngredientsDropDown";
            this.availableIngredientsDropDown.Size = new System.Drawing.Size(319, 49);
            this.availableIngredientsDropDown.TabIndex = 7;
            // 
            // availableIngredientsLabel
            // 
            this.availableIngredientsLabel.AutoSize = true;
            this.availableIngredientsLabel.Location = new System.Drawing.Point(443, 166);
            this.availableIngredientsLabel.Name = "availableIngredientsLabel";
            this.availableIngredientsLabel.Size = new System.Drawing.Size(293, 41);
            this.availableIngredientsLabel.TabIndex = 8;
            this.availableIngredientsLabel.Text = "Available Ingredients";
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.BackColor = System.Drawing.SystemColors.Menu;
            this.addIngredientButton.ForeColor = System.Drawing.Color.Black;
            this.addIngredientButton.Location = new System.Drawing.Point(429, 301);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(319, 81);
            this.addIngredientButton.TabIndex = 9;
            this.addIngredientButton.Text = "Add Ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = false;
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1166, 563);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.availableIngredientsLabel);
            this.Controls.Add(this.availableIngredientsDropDown);
            this.Controls.Add(this.addRecipeButton);
            this.Controls.Add(this.addRecipeHeaderLabel);
            this.Controls.Add(this.addedIngredientsLabel);
            this.Controls.Add(this.addedIngredientsListBox);
            this.Controls.Add(this.existingRecipesLabel);
            this.Controls.Add(this.existingRecipesListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Brown;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddRecipeForm";
            this.Text = "Add New Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox existingRecipesListBox;
        private Label existingRecipesLabel;
        private Label addedIngredientsLabel;
        private ListBox addedIngredientsListBox;
        private Label addRecipeHeaderLabel;
        private Button addRecipeButton;
        private ComboBox availableIngredientsDropDown;
        private Label availableIngredientsLabel;
        private Button addIngredientButton;
    }
}