   M S B A M L   `   `   `  ����C  ?SystemUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SystemUI.AdminUISystemUI.AdminUI  5      %    SystemUI.AdminUI.AddStudentPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:SystemUI.AdminUI     5        N� 
Background
  ����� N� Title$ AddStudentPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6$   $��
First Name��61   $��26(�6C   
�������$��0,10,0,0q�5   +   �� 5    
   -   5         ��Name$ FirstNameTextBox��5       $��1��6,   $��2��6<   $��0,5,0,0q�6I   $��16(�6Z   �� 5!   
   $��1��6   $��3��6$   $��	Last Name��61   $��26(�6B   
�������$��0,10,0,0q�5"   +   �� 5#   
   -   5        $ LastNameTextBox��5#      $��1��6+   $��4��6;   $��0,5,0,0q�6H   $��16(�6Y   �� 5$   
   $��1��6   $��5��6$   $��Email Address��61   $��26(�6F   
�������$��0,10,0,0q�5%   +   �� 5&   
   -   5        $ EmailAddressTextBox��5&      $��1��6/   $��6��6?   $��0,5,0,0q�6L   $��16(�6]   �� 5'   
   $��1��6   $��7��6$   $��Password��61   $��26(�6A   
�������$��0,10,0,0q�5(   +   G� 5)   
   -   5         G�Name$ PasswordTextBox��5)      $��1��6/   $��8��6?   $��0,5,0,0q�6L   $��16(�6]   �� 5*   
   -   5         ��Name$ AddStudentButton��5*      $��1��6+   $��9��6;   $
��0,20q�6H   $��Add student��6V   ���	#FF007FFF$��20(�6�   
�������6�   5+      5,      