   M S B A M L   `   `   `  ����C  ?SystemUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SystemUISystemUI  5          SystemUI.LoginPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:SystemUI     5        N� 
FontFamily$  Segoe UI Light)�5       N� 
Background
 ����� N� Title$ 	LoginPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��1��6   $��0��6$   $��Login��61   $	��100(�5       $��6��6#   ���	#FF007FFF67   �� 5!   
   $��1��6   $��1��6$   $��Username��61   $��30(�6A   $��3��5"      
�������$��0,10,0,0q�6>   �� 5#   
   -   5         ��Name$ LoginBox��5#      $��1��6$   $��2��64   $��6��6A   $��0,5,0,0q�6U   $��24(�6f   �� 5$   
   $��1��6   $��3��6$   $��Password��61   $��30(�6A   $��3��5%      
�������$��0,10,0,0q�6>   G� 5&   
   -   5         G�Name$ PasswordBox��5&      $��1��6+   $��4��6;   $��6��6H   $��0,5,0,0q�6\   $��24(�6m   	� 5'   
   -   5         	�Name$ StudentButton��5'      $��2��6-   $��1��6A   $��5��6Q    	� 	GroupName$ AccountType��6^   $��0,10,0,0q�6v   
�������.��6�   	Student6�   	� 5(   
   -   5        $ TeacherButton��5(      $��2��6-   $��3��6A   $��5��6Q   $ AccountType��6^   $��	0,10,35,0q�6v   
�������.��6�   	Teacher6�   	� 5)   
   -   5        $ AdminButton��5)      $��2��6+   $��5��6?   $��5��6O   $ AccountType��6\   $��0,10,0,0q�6t   
�������.��6�   Admin6�   �� 5*   
   -   5        	 ��Name$	 LoginButton��5*      $��2��6&   $��6��66   $��4��6C   $
��0,20q�6W   $��Login��6e   ���	#FF007FFF$��24(�6�   
�������6�   5+      5,      