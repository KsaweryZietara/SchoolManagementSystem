   M S B A M L   `   `   `  ����C  ?SystemUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SystemUISystemUI  5      $    SystemUI.AdminUI.AdminMenuPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:SystemUI     5        N� 
Background
  ����� N� Title$ AdminMenuPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ AddStudentButton��5      $��0��6+   $��0��6;   $��Add student��6I   ���	#FF007FFF$��24(�6v   
�������6�   �� 5   
   -   5        $ AddTeacherButton��5      $��0��6+   $��1��6;   $��Add teacher��6I   ���	#FF007FFF$��24(�6v   
�������6�   �� 5   
   -   5        $ AddAdminButton��5      $��0��6)   $��2��69   $��	Add Admin��6G   ���	#FF007FFF$��24(�6r   
�������6�   �� 5   
   -   5        $ NewCourseButton��5      $��0��6*   $��3��6:   $��
Add Course��6H   ���	#FF007FFF$��24(�6t   
�������6�    � 5   
   -   5          �Name$ AdminMenuOptions��5      $��1��6*   $��4��6:     � NavigationUIVisibility$ Hidden=�6K   5      5      