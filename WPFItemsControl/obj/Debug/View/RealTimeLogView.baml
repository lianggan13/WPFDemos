   M S B A M L   `   `   `  ����J  FWPFItemsControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPFItemsControl.ViewWPFItemsControl.View  5      E'clr-namespace:WPFItemsControl.ViewModelWPFItemsControl.ViewModel  5      *    $WPFItemsControl.View.RealTimeLogView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WPFItemsControl.View     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      6vm'clr-namespace:WPFItemsControl.ViewModel     5      $	��315��5	      $	��300��5
        � DataContext  5      -   'WPFItemsControl.ViewModel.RealTimeLogVM  5   
   -   5        VM��5      ��5      
� 5   
    
� Center$ 0.4,0.3&�6    
� GradientOrigin$ 	-0.1,-0.6&�6/    
� RadiusX$	 0.8Q�6J    
� RadiusY$	 1.4Q�6X   .��5      �  � Color$ 	#FFA4B3D3��6   � 5       � Offset$ 0.952Q�6   $ 	#FF302C5D��6*   � 5      $ 0.163Q�6   $ 	#FF96AAD4��6*   5      .��5      � $��3q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��5      $
��Left=�5      $��Center=�5      ���	#44FFFFFF$��实时日志��5!      �� 5"   
   $��0��5#      $��Right=�5$      $��Center=�5%      �� 5&      ���	#66DFFDFF.�6/   详情63   5'      �� 5(   
   $��1��5)      $��0,8,0,0q�5*       �� AlternationCount$ 2��5+      ��5,      �� *Logs+��5-      �� 5.      .R�5/      � $��30��6   $��0,0,0,6q�6*   .+�50      �� 	 ��Name$
	 back��51      ���	#11FFFFFF
 �� CornerRadius$
 10��53      $y�	Collapsed=�54      � 55      
������� � ColumnDefinitions 56      �� 57   "   $
��auto �63   �� 58   "   �� 59   "   $
��1.3* �63   �� 5:   "   $
��auto �63   .+�5<      �� $��0,0,15,0q�5=   !   $��Center=�5>   !   ��5?   !   �� *Num+ �� StringFormat$ {0:00}���� 5@      $��1��5A   !   $��Center=�5B   !   ��5C   !   �� *
DeviceName+�� 5D      $��2��5E   !   $
��Left=�5F   !   $��Center=�5G   !   ��5H   !   �� *	LogInfo+�� 5J      $
	 warn��5K   !   $��3��5L   !   $��0,1,1,1q�5M   !   $
 	0,10,10,0��5N   !   ._�5O   "   �� $��2,0,0,0q�6,   $��Center=�6=   ��6X   �� *	LogType+5P      5R      5S       �� Triggers 5T      P� 5U       P� Property �@��AlternationIndex P� Value$ 0��6K   . �5V      ��  �� 
TargetName$
 back��6%    �� Property � y� �� Value$ Visible=�6M   5W      �� 5Y       �� Value$
 Warn��6B    �� Binding 6&   �� *	LogType+.a�5Z      �� $
 warn��6%    � �� �	#66FF00006M   5[      5]      5_      5`      5a      