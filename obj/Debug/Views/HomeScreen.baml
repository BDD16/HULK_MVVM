   M S B A M L   `   `   `  ����?  ;HULK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:HULK.Views
HULK.Views  5          HULK.Views.HomeScreen   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      l hMicrosoft.Practices.Prism.Composition, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35.cal$http://www.codeplex.com/CompositeWPF  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:HULK.Views     5        N� Title$  
HomeScreen��5
      .��5      � ���	#FF1F2120$��	0,0,0,-70q�6#   .+�5   
   � -   5         �Name$ HulkEnigmaGrid��5      $��Center=�6'   $	��300��6B   $��
0,-200,0,0q�6N   .+�5      � -   5        $ TabSettingsGrid��5      $��Center=�6,   $	��300��6G   $��
0,-290,0,0q�6S   .+�5      �� $��2q�6   ���	#FF591C97 �� CornerRadius$ 3��6E   $��0,0,0,-6q�6V   �� 5      -   5         ��Name$ SettingsLabel��5      $��Settings��60   $
��Left=�6C   $��26��6^   $��10,6,0,0q�6j   $	��Top=�6}   $��57��6�   ���	#FF2ABD00 � ToolTip$ Savage or Professor Hulk?��6�    J� Opacity$ 0.985Q�6  ���	#FF1F2120���	#FF1F2120��6�   ��  �� Path$ Settings_Click�6*  �� 5      -   5        $ LogoutLabel��5      $��Logout��6.   $
��Left=�6?   $��26��6Z   $��	237,6,0,0q�6f   $	��Top=�6{   $��53��6�   ���	#FF2ABD00$ Revert Back to Dr. Banner��6�   ���	#FF1F2120���	#FF1F2120��6�   �� $ Logout_Click�6  �� 5      -   5        $ AddFriend_Label��5      $��	AddFriend��62   $
��Left=�6F   $��27��6a   $��	119,5,0,0q�6m   $	��Top=�6�   $��64��6�   ���	#FF2ABD00$ Click to Find Mr. Blue��6�   ���	#FF1F2120$��1,3,1,1q�6�   ���	#FF1F21206  5      �� 5      -   5         ��Name$ Banner��5      $
��Left=�6$   $��40��6?   $��	72,27,0,0q�6K   $	��Top=�6^   $	��144��6v   $��Images/HULKbanner.png��6�   �� 5      -   5        $ EncryptButton��5      $
��Left=�6+   $��34��6F   $��222,335,0,-84q�6R   $	��Top=�6i   $��33��6�   $��Images/Dagger.png��6�   $ Encrypt��6�    J� OpacityMask
 �   �6�   �� 5       -   5        $ 
SendButton��5       $
��Left=�6(   $��39��6C   $��222,369,0,-123q�6O   $	��Top=�6g   $��33��6   $��Images/Smash.png��6�   $
 Send��6�   
 �   �6�   �� 5!      -	   5        	 ��Name$	 ChatBox��5!      $
��Left=�6'   $	��253��6B   $��63,72,0,-40q�6O   
 �� TextWrapping$

 Wrap=�6d   $	��Top=�6x   $	��153��6�   ���	#FF525252$
 0.75Q�6�   $!��Mr. Blue: Welcome Mr. Green��6�   ���	#FF20A1F76�   �� 5"      -
   5        $	 
MessageBox��5"      $
��Left=�6*   $��25��6E   $��61,374,0,-114q�6Q   $

 Wrap=�6h   $	��Top=�6|   $	��153��6�   ���	#FF575252$
 0.75Q�6�   $ Message Text��6�   
 �   ����	#FF6CF9076�   �� 5#      -   5        $	 
EncryptBox��5#      $
��Left=�6*   $��25��6E   $��61,344,0,-84q�6Q   $

 Wrap=�6g   $	��Top=�6{   $	��153��6�   ���	#FF5D2E2E$
 0.75Q�6�   $ Cipher Text��6�   ���	#FFF9EE07
 �   �6�   5$      5%      5&      