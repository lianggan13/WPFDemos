   M S B A M L   `   `   `  ����E  AWPFTextBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WPFTextBox.ValidateTextBoxWPFTextBox.ValidateTextBox  5      .    (WPFTextBox.ValidateTextBox.SearchTextBox   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:WPFTextBox.ValidateTextBox     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border��%�   &	        &	 #     &	 F     �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   5      .��5      � .+�5   
   �� $��Center=�6    �� TextAlignment$
 Left=�6-   .��6B   ��5      �� 5       �� 
TargetType" ��6"   .R�5      ��  ��Name$ border��5      #��z��5      #��z��5      #��z��5       �� CornerRadius$ 5��5       J� SnapsToDevicePixels . ._�5      � .+�5      ��  ��Name$ PART_ContentHost��5   !   |�.  $��Hidden=�5   !   $��Hidden=�5    !   �� 5!      $��mt��5"   !   $��Center=�5#   !   
�������$!��Search for what you like...��5%   !   $y�	Collapsed=�5&   !   5'      5)       �� Triggers 5*      P� 5+      	 P� Property	 � {�
 P� Value
 .  . �5,      ��  �� 
TargetName$ border��6%    �� Property �@J�Opacity �� Value$
 0.56Q�6L   5-      P� 5.      	 �@J�IsMouseOver
 . . �5/      �� $ border��6%   # [ 6P    � ��50      P� 51      	 �@J�IsKeyboardFocused
 . . �52      �� $ border��6%   # [ 6P    � ��53      �� 54       �� Value$  ��6j    �� Binding 6&   �� *Text+ �� RelativeSource ��  �� Mode$
 Self=�.a�55      �� $ mt��6%    � y�$ Visible=�6K   56      58      .��59       5:      5;      5<      