   M S B A M L   `   `   `  ���� F  BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TaskManagerTaskManager      TaskManager.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:TaskManager       � Title$  
MainWindow��$��580.112��$	��532�� � 
ResizeMode$ NoResize=�.��� .+��� $
��Left=�$	��442��$��	10,87,0,0q�$	��Top=�$	��497�����	#FFBB4141.���� -    ��Name$ proccesspanel���� -    ��Name$ filter��$
��Left=�$��23��$��	10,36,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��497���� -    ��Name$ example��$��Button��$
��Left=�$��
10,-63,0,0q�$	��Top=�$	��469�����	#00DDDDDD�� $
��Left=�$��	10,20,0,0q�$
��Wrap=�$	��Top=��� $�Filter���� �� �� -   $��Refresh��$
��Left=�$��
432,10,0,0q�$	��Top=�$��75��
��������� -    ��Name$ checkbox��$��Collapse Similar��$
��Left=�$	��Top=�$��20��$	��112��$��10,8,0,0q�� -    �Name$ Ram_bar�����	#FFE6E6E6$
��Left=�$��20��$��
138,10,0,0q�$	��Top=�$	��122�� J� RenderTransformOrigin$ 0.5,0.5&�	 � Value$		 100Q����� 
 �� EndPoint$
 0.5,1&� �� 
StartPoint$ 0.5,0&� �� RelativeTransform ��  �� Angle$	 270Q�.���  � Color$
 Lime�� � Offset$ 1Q�� $	 Red��$ 0.183Q�� $
 Lime��$ 0.487Q�� $ 	#FFF3FF00��$ 0.465Q�� $ 	#FFFBFB00��$ 0.204Q�z�V� .~��� �� �� $	 180Q�T� � -   $ CPU_bar�����	#FFE6E6E6$
��Left=�$��20��$��
289,10,0,0q�$	��Top=�$	��122��$		 100Q� � LargeChange$ 0Q�$ 0.5,0.5&�z�V� .~��� �� �� $
 -180Q�T� ���� $
 0.5,1&�$ 0.5,0&� �� $	 270Q�.��� $
 Lime��$ 1Q�� $	 Red��$ 0.183Q�� $
 Lime��$ 0.487Q�� $ 	#FFF3FF00��$ 0.465Q�� $ 	#FFFBFB00��$ 0.204Q��� $
��Left=�$��18��$��
289,11,0,0q�$
��Wrap=�$��
CPU usage:��$	��Top=�$��63���� $
��Left=�$��
138,11,0,0q�$
��Wrap=�$��
RAM Usage:��$	��Top=�$ -0.571,0&�$��19���� -    ��Name$ Ram_use��$
��Left=�$��19��$��
207,11,0,0q�$
��Wrap=�$��0%��$	��Top=�$��53��$ 2.237,-6.684&��� -	   $ CPU_percent��$
��Left=�$��
352,11,0,0q�$
��Wrap=�$��0%��$	��Top=�$��19��$��59���� -
   $ 
sortbyname��$��Name /\��$
��Left=�$��	10,62,0,0q�$	��Top=�$	��164��$��25��
��������� -   $ 	sortbypid��$	��Pid��$
��Left=�$��
174,62,0,0q�$	��Top=�$	��168��$��25��
��������� -   $ 	sortbyram��$	��Ram��$
��Left=�$��
342,62,0,0q�$	��Top=�$	��148��$��25��
��������� $
��Left=�$��20��$��
490,65,0,0q�$	��Top=�$��19��$��DrEthan.jpg��