   M S B A M L   `   `   `  ����G  CFBSI Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FBSI_ManagerFBSI_Manager  5          FBSI_Manager.AddressView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FBSI_Manager     5      -   5        .��5      � .+�5
   
   � y�6   �� *IsHorizontal+   BoolToVisibility  �� 	Converter#  [   � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $	��100��6#   $	��150��62   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $	��100��6#   $	��150��62   �� 5      $��* �6#   .+�5      �� $��0��6   $��Center=�6D   $��2q�6_    d� 	IsChecked 6'   �� *IsMain+{�6j   �� *
IsEditable+�� 5      $��1��6   $��2q�6j   ��6'   �� *Types+ �� SelectedItem 6E   �� *AddressType+{�6u   �� *
IsEditable+�� 5      $��2��6   ��6&   �� *Name+�� 5      $��3��6   ��6&   �� *City+�� 5      $��4��6   $��2q�6e   ��6'   �� *States+ 6F   �� *State+{�6p   �� *
IsEditable+�� 5      $��5��6   ��6&   �� *	ZipCode+5      � 5   
   $
��Left=�6^   y�6   �� *
IsVertical+#  [   5      �� 5      $��75 �6#   �� 5       $��* �6#    � RowDefinitions 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      .+�5,      �� $��0��6   $��Primary��6!   �� 5-      $��1��6   $
��Type��6!   �� 5.      $��2��6   $
��Name��6!   �� 5/      $��3��6   $
��City��6!   �� 50      $��4��6   $��State��6!   �� 51      $��5��6   $��Zipcode��6!   �� 53      $��1��6   $��0��6'   $��Center=�6Q   $��2q�6l    64   �� *IsMain+{�6w   �� *
IsEditable+�� 54      $��1��6   $��1��6'   $��2q�6w   ��64   �� *Types+ 6R   �� *AddressType+{�6�   �� *
IsEditable+�� 55      $��1��6   $��2��6&   ��63   �� *Name+�� 56      $��1��6   $��3��6&   ��63   �� *City+�� 57      $��1��6   $��4��6'   $��2q�6r   ��64   �� *States+ 6S   �� *State+{�6}   �� *
IsEditable+�� 58      $��1��6   $��5��6&   ��63   �� *	ZipCode+5:      5C      5D      