   M S B A M L   `   `   `  ����K  GBotNet Server UI, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BotNet_Server_UIBotNet_Server_UI  5   	        BotNet_Server_UI.DialogBox   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:BotNet_Server_UI     5   	   -   5          � Title$  Login��5   	   $	��170��6   $	��170��6$    � WindowState$ Normal=�60    � 
ResizeMode$ CanMinimize=�6E   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Enter server address:��6   $��Stretch=�61   $��Center=�6O   $��0��6j   �� 5   
   -   5         ��Name$ ServerTextBox��5      $��Stretch=�6)   $��Center=�6G   $��1��6z   �� 5   
   $��Enter admin password:��6   $��Stretch=�61   $��Center=�6O   $��2��6j   �� 5   
   -   5        $ sResponseTextBox��5      $��Stretch=�6,   $��Stretch=�6J   $��3��6~   $y�	Collapsed=�6�   G� 5   
   -   5         G�Name$ ResponseTextBox��5      $��Stretch=�6/   $��Stretch=�6M   $��3��6�   �� 5   
   -   5         ��Name$ 
AuthButton��5      $��OK��6%   $��Stretch=�62   $��Center=�6P   $��4��6�   �� 5   
   -   5         ��Name$ cbShow��5      $��Show letters��6#   $��Stretch=�6:   $��Center=�6X    d� 	IsChecked$ FalseY�6s   $��5��6�   5      5      