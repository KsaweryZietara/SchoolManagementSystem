   M S B A M L   `   `   `  ����C  ?SystemUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SystemUI.TeacherUISystemUI.TeacherUI  5      +    %SystemUI.TeacherUI.TeacherCoursesPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:SystemUI.TeacherUI     5        N� 
Background
  ����� N� Title$ TeacherCoursesPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ CoursesListBox��5      $��1��6*   $��1��6:   $��3��6G   $	��150��6[   $	��400��6h   6t   �� 5   
   -   5         ��Name$ StudentsListView��5      $��1��6-   $��2��6=   $��3��6J   $	��150��6_   $	��400��6l   $��0, 10q�6x   �� 5   
   $��1��6   $��3��6$   $
��Name��61   $��26(�6=   
�������$��0,10,0,0q�5   +   �� 5   
   -   5         ��Name$ NameTextBox��5      $��1��6'   $��4��67   $��0,5,10,0q�6D   $��16(�6V   �� 5    
   $��2��6   $��3��6$   $��Value��61   $��26(�6>   
�������$��0,10,0,0q�5!   +   �� 5"   
   -   5        $ ValueTextBox��5"      $��2��6(   $��4��68   $��0,5,10,0q�6E   $��16(�6W   �� 5#   
   -   5         ��Name$ AddGradeButton��5#      $��3��6)   $��4��69   $��	Add Grade��6F   ���	#FF007FFF$��20(�6q   
�������6�   5$      5%      