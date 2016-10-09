using UnityEngine;
/// <summary>
/// MonoBehaviourの定義済み関数を日本語の説明と共に空実装しています。
/// 利用するにはこのファイルをプロジェクトに入れ、MonoBehaviourの代わりにこのクラスを継承します。
/// 継承先のクラスでMonoBehaviourの定義済み関数を再定義するにはoverride修飾子を明示的に付ける必要があります。
/// Visual Studioを使用する際に便利なように作られています。
/// </summary>
public abstract class MonoBehaviourJ : MonoBehaviour {
	/// <summary>
	/// 毎フレーム呼び出されます。
	/// </summary>
	public virtual void Update() {
	}

	/// <summary>
	/// 毎フレーム呼び出されます。Updateよりも後に実行されます。
	/// </summary>
	public virtual void LateUpdate() {
	}

	/// <summary>
	/// フレームより高頻度なフィックスドフレームごとに呼び出されます。
	/// </summary>
	public virtual void FixedUpdate() {
	}

	/// <summary>
	/// スクリプトのインスタンスがロードされたときに呼び出されます。
	/// </summary>
	public virtual void Awake() {
	}

	/// <summary>
	/// Update関数が呼び出される直前に１度だけ呼び出されます。
	/// </summary>
	public virtual void Start() {
	}

	/// <summary>
	/// 値をデフォルトにリセットします。
	/// </summary>
	public virtual void Reset() {
	}

	/// <summary>
	/// マウスがGUIElementやColliderに入ったときに呼び出されます。
	/// </summary>
	public virtual void OnMouseEnter() {
	}

	/// <summary>
	/// マウスがGUIElementやColliderの上に来たときに呼び出されます。
	/// </summary>
	public virtual void OnMouseOver() {
	}

	/// <summary>
	/// マウスが、GUIElementやColliderから外に出たときに呼び出されます。
	/// </summary>
	public virtual void OnMouseExit() {
	}

	/// <summary>
	/// ユーザーがマウスのボタンを押し下げたときに呼び出されます。
	/// </summary>
	public virtual void OnMouseDown() {
	}

	/// <summary>
	/// ユーザーがマウスのボタンを離したときに呼び出されます。
	/// </summary>
	public virtual void OnMouseUp() {
	}

	/// <summary>
	/// ユーザーがGUIElementやColliderをクリックしたまま、マウスを移動したときに呼び出されます。
	/// </summary>
	public virtual void OnMouseDrag() {
	}

	/// <summary>
	/// Triggerに他のColliderが入ったときに呼び出されます。
	/// </summary>
	/// <param name="other"></param>
	public virtual void OnTriggerEnter(Collider other) {
	}

	/// <summary>
	/// Triggerから他のColliderが出たときに呼び出されます。
	/// </summary>
	/// <param name="other"></param>
	public virtual void OnTriggerExit(Collider other) {
	}

	/// <summary>
	/// Triggerに他のColliderが留まっているときに毎フレーム呼び出されます。
	/// </summary>
	/// <param name="other"></param>
	public virtual void OnTriggerStay(Collider other) {
	}

	/// <summary>
	/// ColliderやRigidbodyが他のColliderやRigidbodyに触れたときに呼び出されます。
	/// </summary>
	/// <param name="collision"></param>
	public virtual void OnCollisionEnter(Collision collision) {
	}

	/// <summary>
	/// ColliderやRigidbodyが他のColliderやRigidbodyから離れたときに呼び出されます。
	/// </summary>
	/// <param name="collisionInfo"></param>
	public virtual void OnCollisionExit(Collision collisionInfo) {
	}

	/// <summary>
	/// ColliderやRigidbodyが他のColliderやRigidbodyに触れ続けているときに毎フレーム呼び出されます。
	/// </summary>
	/// <param name="collisionInfo"></param>
	public virtual void OnCollisionStay(Collision collisionInfo) {
	}

	/// <summary>
	/// 移動中にコントローラーがColliderに衝突したときに呼び出されます。
	/// </summary>
	/// <param name="hit"></param>
	public virtual void OnControllerColliderHit(ControllerColliderHit hit) {
	}

	/// <summary>
	/// ジョイントが破壊されたときに呼び出されます。
	/// </summary>
	/// <param name="breakForce"></param>
	public virtual void OnJointBreak(float breakForce) {
	}

	/// <summary>
	/// パーティクルがColliderに衝突したときに呼び出されます。
	/// </summary>
	/// <param name="other"></param>
	public virtual void OnParticleCollision(GameObject other) {
	}

	/// <summary>
	/// レンダラーがカメラに対して可視状態になったときに呼び出されます。
	/// </summary>
	public virtual void OnBecameVisible() {
	}

	/// <summary>
	/// レンダラーがカメラに対して不可視状態になったときに呼び出されます。
	/// </summary>
	public virtual void OnBecameInvisible() {
	}

	/// <summary>
	/// 新しいレベルがロードされたときに呼び出されます。
	/// </summary>
	/// <param name="level"></param>
	public virtual void OnLevelWasLoaded(int level) {
	}

	/// <summary>
	/// オブジェクトが有効化されたときに呼び出されます。
	/// </summary>
	public virtual void OnEnable() {
	}

	/// <summary>
	/// オブジェクトが無効化されたときに呼び出されます。
	/// </summary>
	public virtual void OnDisable() {
	}

	/// <summary>
	/// オブジェクトが破棄される直前に呼び出されます。
	/// </summary>
	public virtual void OnDestroy() {
	}

	/// <summary>
	/// カメラがシーンをカリングする前に呼び出されます。
	/// </summary>
	public virtual void OnPreCull() {
	}

	/// <summary>
	/// カメラがシーンのレンダリングを開始する前に呼び出されます。
	/// </summary>
	public virtual void OnPreRender() {
	}

	/// <summary>
	/// カメラのシーンがレンダリングを終了したときに呼び出されます。
	/// </summary>
	public virtual void OnPostRender() {
	}

	/// <summary>
	/// カメラがシーンをレンダリング完了したときに呼び出されます。
	/// </summary>
	public virtual void OnRenderObject() {
	}

	/// <summary>
	/// オブジェクトが可視状態のとき、カメラごとに一度呼び出されます。
	/// </summary>
	public virtual void OnWillRenderObject() {
	}

	/// <summary>
	/// GUIの描画とイベントのハンドリングのために呼び出されます。
	/// </summary>
	public virtual void OnGUI() {
	}

	/// <summary>
	/// 全てのレンダーイメージのレンダリングが完了したときに呼び出されます。
	/// </summary>
	/// <param name="source"></param>
	/// <param name="destination"></param>
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination) {
	}

	/// <summary>
	/// 選択したオブジェクトのギズモを表示するときは、この関数を実装します。
	/// </summary>
	public virtual void OnDrawGizmosSelected() {
	}

	/// <summary>
	/// オブジェクトのギズモを表示するときは、この関数を実装します。
	/// </summary>
	public virtual void OnDrawGizmos() {
	}

	/// <summary>
	/// アプリケーションが一時停止したときに呼び出されます。
	/// </summary>
	/// <param name="pause"></param>
	public virtual void OnApplicationPause(bool pause) {
	}

	/// <summary>
	/// アプリケーションがフォーカスされたときに呼び出されます。
	/// </summary>
	/// <param name="focus"></param>
	public virtual void OnApplicationFocus(bool focus) {
	}

	/// <summary>
	/// アプリケーションが終了される直前に呼び出されます。
	/// </summary>
	public virtual void OnApplicationQuit() {
	}

	/// <summary>
	/// 新しいプレイヤーが接続されたときにサーバーで呼び出されます。
	/// </summary>
	/// <param name="player"></param>
	//public virtual void OnPlayerConnectedd(NetworkPlayer player) {
	//}

	/// <summary>
	/// Network.InitializeServerが呼び出され完了したときに呼び出されます。
	/// </summary>
	public virtual void OnServerInitialized() {
	}

	/// <summary>
	/// クライアントがサーバーに接続完了したときに呼び出されます。
	/// </summary>
	public virtual void OnConnectedToServer() {
	}

	/// <summary>
	/// サーバーからプレイヤーが切断されたときに呼び出されます。
	/// </summary>
	/// <param name="player"></param>
	//public virtual void OnPlayerDisconnected(NetworkPlayer player) {
	//}

	/// <summary>
	/// クライアントがサーバーへの接続を失ったときに呼び出されます。
	/// </summary>
	/// <param name="info"></param>
	//public virtual void OnDisconnectedFromServer(NetworkDisconnection info) {
	//}

	/// <summary>
	/// 何らかの理由で接続が失敗した場合に、クライアントで呼び出されます。
	/// </summary>
	/// <param name="error"></param>
	//public virtual void OnFailedToConnect(NetworkConnectionError error) {
	//}

	/// <summary>
	/// マスターサーバーへの接続に問題が発生したときに、クライアントやサーバーで呼び出されます。
	/// </summary>
	/// <param name="info"></param>
	//public virtual void OnFailedToConnectToMasterServer(NetworkConnectionError info) {
	//}

	/// <summary>
	/// マスターサーバーからのイベントを受け取ったときに、クライアントやサーバーで呼び出されます。
	/// </summary>
	/// <param name="msEvent"></param>
	//public virtual void OnMasterServerEvent(MasterServerEvent msEvent) {
	//}

	/// <summary>
	/// ネットワーク上でNetwork.Instantiateを用いてインスタンス化されたオブジェクトに対して呼び出されます。
	/// </summary>
	/// <param name="info"></param>
	//public virtual void OnNetworkInstantiate(NetworkMessageInfo info) {
	//}

	/// <summary>
	/// ネットワークビューによって使われる値の直列化をカスタマイズしたいときに使います。
	/// </summary>
	/// <param name="stream"></param>
	/// <param name="info"></param>
	//public virtual void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info) {
	//}
}
