   M S B A M L   `   `   `  ����H  DWPFTabControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFTabControlWPFTabControl  5          WPFTabControl.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WPFTabControl     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��800��5	      $	��450��5
      .��5      � .+�5   
   ��  �� SelectedIndex$ 0��5      ��5      �� *
TabItems+��5      �� 5       �� DataType   WPFTabControl.TabItem"  6   .R�5      �� ��6    ��  �� Path$ Header�5       �� ContentTemplate 5      �� 5      "  6   .R�5      �� ��6#   �� *AntennaPathlosses+��5      �� 5      #   WPFTabControl.AntennaPathloss"  6+   .R�5   "   �� $��0,3,0,0q�6-    �� Orientation$ 
Horizontal=�6>   .+�5   &   �� $��70��5   )   $��Center=�5   )    �� TextAlignment$
 Left=�5   )   ��5   )   �� *Name+ �� StringFormat$ {0}：�� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�5   )   �� 5    &   $	��232��5!   )   $��Center=�5"   )   $
 Left=�5$   )   $��CharacterEllipsis=�5%   )   ��5#   )   �� *
Pathloss+$ TwoWay=�$	 PropertyChanged=�
 � ToolTip
 5&   )   �� *
Pathloss+�� 5'   &   -   5        $��60��5(   )   $��20��5)   )   $	��5,0q�5*   )   $��Right=�5+   )   $��Update��5-   )   
 � Tag 5.   )   �� 5/   #   50      ��53      �� 54      .R�55   "   $� 56      58      59      5;      5<      5=      