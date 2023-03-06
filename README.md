波動関数算出　＆　Unity上に表示

波動関数を算出しUnity上にメッシュとして表示させるものです。

ファイルの容量の問題でscript部分だけ上げてあります。

雑多なテストコードが多いので主となるコード↓

・Manager.cs(球面調和関数の算出)

・MeshManager.cs(球面調和関数のメッシュ表示)

![Arrange](https://user-images.githubusercontent.com/126846851/223052426-50bc8890-a73e-4d22-b5cc-25c5d8011793.jpg)

↑Unity上での球面調和関数の表示


・RadialWave.cs(動径波動関数、波動関数の算出、波動関数のメッシュ表示)

RadialWave.csの計算部分は完成していますが、表示部分が未完成です。

最終的にVR機器(MetaQuest2)での実装を目標としており、ユーザが量子数などを指定し表示させられるようにします。
