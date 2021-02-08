# unity-mirrorboot

[![Open in Gitpod](https://gitpod.io/button/open-in-gitpod.svg)](https://gitpod.io/#https://github.com/tk-aria/unity-mirrorboot)

multiple launches of the same 'Unity Project'

## Install

```
{
    "com.ariasdk.unity-mirrorboot": "https://github.com/tk-aria/unity-mirrorboot.git?path=Assets/External/Mirrorboot#v0.0.1"
}
```


<!--
<p align="center">
    <h1 align="center">unity multi-client</h1>
</p>

ベースとなるUnityProjectからシンボリックリンクを生成します。

## 使い道
- Unityで通信ロジック開発時の複数クライアント検証時
- Unity内にサーバーロジックを内包している場合の、サーバー、クライアント開発時
- Jenkinsのビルド処理時
など...

使い道は様々な気がしますが,自分が思いつく方法だとこんなものでしょうか?

## デモ
![demo_image]()

Assetsと同階層(Project以下)にファイルを配置して該当ファイルをMacならシェルから実行、
Windowsは、コマンドプロンプトかダブルクリックで実行できます。
(コンフル整備中なので、この辺りは暫しお待ちを...)

Unity > ProjectSettings > Run in background をtrueにするのがオススメ.

※ Macの場合  
- .shファイルに関して...  
gitでファイル権限を監視できない影響で初めに各ローカル上で以下のコマンドを実行してください。  
ファイルがあるディレクトリで以下を実行
```
# 権限に関しては各自で設定してください、めんどくさい人は下をコピペで！.
$ chmod 777 *.sh
``

[tips]
- ２つのプロジェクト間でファイルは共有されるので、片方の変更をもう片方に適用して...などの作業が要らなくなります。
- 協力バトル用に追加のPC申請をしなくて済む

[用途]
- 複数クライアントのデバッグなど...

-->
