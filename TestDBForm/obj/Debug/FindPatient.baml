   M S B A M L   `   `   `  ????E  ATestDBForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TestDBForm
TestDBForm  5   	       TestDBForm.FindPatient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TestDBForm     5   	     ? Title$  FindPatient??5   	   $	??480??6   $	??500??6*   .??5	      ? .+?5
   
   ?? $
??Left=?6   $??258,124,0,0q?6+   $	??Top=?6@   ?? 5   
   $??Запросить по??6   $??5q?6)   $	??200??65   $	??200??6A   $
??Left=?6N   $	??Top=?6i   $??	16,16,0,0q?6?   .??5      ?? .+?5      ?? $??Параметр??6   $??6,8,0,0q?6+   $	??120??6<   ?? 5      -   5         ??Name$ ParamBox??5      $	??120??6-   $??22??69   $??6,0,0,0q?6E   .@?5      ?? ?? 6!   $?ID паниента??6%   6;   ?? 5      ?? 6!   $?Фамилия??6%   67   ?? 5      ?? 6!   $?Имя??6%   63   ?? 5      ?? 6!   $?Отчество??6%   68   ?? 5      ?? 6!   $?Дата рождения??6%   6=   ?? 5      ?? 6!   $?Телефон??6%   67   5      ?? 5      $	??120??6   $??Значение??6$   $??6,8,0,0q?67   ?? 5      -   5         ??Name$ ValueTxt??5      $
??Left=?6,   $??32,0,0,0q?6G    ?? TextWrapping$
 Wrap=?6Y   $	??Top=?6m   $	??120??6?    J? RenderTransformOrigin$ 	0.5,0.448&?6?   $??18??6?   ?? 5      -   5         ??Name$ FindPacientBtn??5      $??Запросить??61   $
??Left=?6E   $??	32,16,0,0q?6`   $	??Top=?6s   $	??120??6?   $??30??6?    ?? 	IsDefault . $??15(?6?   6?   5      5      ?? 5   
   $#??Данные пациента??6   $??5q?6,   $	??450??68   $	??150??6D   $
??Left=?6Q   $??Bottom=?6l   $??	16,0,0,80q?6?   .??5      ?? .+?5      ?? -   5         ??Name$ EntryesCountLbl??5      $?? ??61   $??Right=?6<   $??0,0,0,0q?6X   $	??Top=?6i   ?? 5      $??ID пациента??6   $
??Left=?6.   $??
16,-16,0,0q?6I   $	??Top=?6]   ?? 5      -   5        $ PatientIDTxt??5      $
??Left=?60   $??16,0,0,0q?6K   $
 Wrap=?6]   $	??Top=?6q   $	??120??6?   $ 	0.5,0.448&?6?    ?? 
IsReadOnly . $??18??6?   ?? 5       $??Фамилия??6   $
??Left=?6*   $??152,-44,0,0q?6E   $	??Top=?6Z   ?? 5!      -   5        $ PatientSureNameTxt??5!      $
??Left=?66   $??152,-18,0,0q?6Q   $
 Wrap=?6f   $	??Top=?6z   $	??120??6?   $ 	0.5,0.448&?6?    . $??18??6?   ?? 5"      $??Имя??6   $
??Left=?6&   $??288,-44,0,0q?6A   $	??Top=?6V   ?? 5#      -   5        $ PatientNameTxt??5#      $
??Left=?62   $??288,-18,0,0q?6M   $
 Wrap=?6b   $	??Top=?6v   $	??120??6?   $ 	0.5,0.448&?6?    . $??18??6?   ?? 5$      $??Отчество??6   $
??Left=?6+   $??16,0,0,0q?6F   $	??Top=?6X   ?? 5%      -   5        $ PatientMiddleNameTxt??5%      $
??Left=?68   $??16,0,0,0q?6S   $
 Wrap=?6e   $	??Top=?6y   $	??120??6?   $ 	0.5,0.448&?6?    . $??18??6?   ?? 5&      $??Дата рождения??6   $
??Left=?60   $??152,-44,0,0q?6K   $	??Top=?6`   ?? 5'      -	   5        $ PatientBirthDateTxt??5'      $
??Left=?67   $??152,-18,0,0q?6R   $
 Wrap=?6g   $	??Top=?6{   $	??120??6?   $ 	0.5,0.448&?6?    . $??18??6?   ?? 5(      $??Телефон??6   $
??Left=?6*   $??288,-44,0,0q?6E   $	??Top=?6Z   ?? 5)      -
   5        $ PatientPhoneTxt??5)      $
??Left=?63   $??288,-18,0,0q?6N   $
 Wrap=?6c   $	??Top=?6w   $	??120??6?   $ 	0.5,0.448&?6?    . $??18??6?   5+      5,      ?? 5-   
   -   5        $ BackBtn??5-      $??
Назад??6"   $
??Left=?62   $??	32,0,0,32q?6M   $??Bottom=?6`   $	??120??6{   $??30??6?    . $??15(?6?   6?   ?? 5.   
   -   5        $ NextEntryBtn??5.      $??>??6'   $
??Left=?66   $??436,402,0,0q?6Q   $	??Top=?6f   $??30??6~   $??30??6?   6?   ?? 5/   
   -   5        $ PreviousEntryBtn??5/      $??<??6+   $
??Left=?6:   $??390,402,0,0q?6U   $	??Top=?6j   $??30??6?   $??30??6?   6?   ?? 50   
   -   5        $ ToXML??50      $)??#Экспортировать в XML??6    $
??Left=?6?   $??336,186,0,0q?6Z   $	??Top=?6o   $??30??6?   $	??130??6?   $ 0.477,-0.232&?6?   51      52      