   M S B A M L   `   `   `  ����L  HYour Besr Adviser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Your_Besr_AdviserYour_Besr_Adviser  5   	       Your_Besr_Adviser.Library   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Your_Besr_Adviser     5   	     � Title$  Library��5   	   $	��400��6   $	��600��6&    � 
ResizeMode$ NoResize=�63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Teachers��5   r   $
��Left=�6   $	��258��6.   $	��Top=�6;   $	��277��6S   $��	10,10,0,0q�6_      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 277 6%      Header$ Учителя��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *NameTeachers+5        5   
   -   5        $ Предметы��5   �   $
��Left=�6   $	��258��6.   $	��Top=�6;   $	��277��6S   $��	10,10,0,0q�6_   $��1��6r    .   5        5      $	 277 6%   $ Предметы��61    6C   �� *NameSubjects+5      �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��28��6?   $��
10,290,0,0q�6K   $	��Top=�6_   $	��134��6w   6�   �� 5   
   $��Удалить��6   $
��Left=�6#   $��28��6>   $��160,290,0,0q�6J   $	��Top=�6_   $	��127��6w   �� 5   
   $��Удалить��6   $
��Left=�6#   $��28��6>   $	��Top=�6J   $	��129��6b   $��1��6n   $��158,290,0,0q�6~   �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��28��6?   $	��Top=�6K   $	��132��6c   $��1��6o   $��
10,290,0,0q�6   6�   �� 5   
   -   5        $��2��5      $��
Назад��6%   $
��Left=�65   $��21��6P   $��264,323,0,0q�6\   $	��Top=�6q   $��67��6�   6�   5      5       