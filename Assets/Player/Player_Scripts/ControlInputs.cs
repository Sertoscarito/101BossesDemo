using UnityEngine;
using System.Collections;

public class ControlInputs : MonoBehaviour {


	public static KeyCode Botton_Jump
	{
		get
		{
			return botton_jumP;
		}
	}
	public static KeyCode Botton_Right
	{
		get
		{
			return botton_right;
		}
	}
	public static KeyCode Botton_Left
	{
		get
		{
			return botton_left;
		}
	}

	public static KeyCode Botton_Up
	{
		get
		{
			return botton_up;
		}
	}

	public static KeyCode Botton_Down
	{
		get
		{
			return botton_down;
		}
	}

	public static KeyCode Botton_Golpear
	{
		get
		{
			return botton_golpear;
		}
	}

	public static KeyCode Botton_Accionar
	{
		get
		{
			return botton_accionar;
		}
	}

	public static KeyCode Cambiar_Municion_POS
	{
		get
		{
			return cambiar_municion_pos;
		}
	}

	public static KeyCode Cambiar_Municion_NEG
	{
		get
		{
			return cambiar_municion_neg;
		}
	}
	
	public static KeyCode MandoPlay_X
	{
		get
		{
			return mando_play_x;
		}
	}
	
	public static KeyCode MandoPlay_Cuadrado
	{
		get
		{
			return mando_play_cuadrado;
		}
	}
	
	public static KeyCode MandoPlay_Triangulo
	{
		get
		{
			return mando_play_triangulo;
		}
	}

	public static KeyCode botton_jumP;
	public static KeyCode botton_right;
	public static KeyCode botton_left;
	public static KeyCode botton_up;
	public static KeyCode botton_down;
	public static KeyCode botton_golpear;
	public static KeyCode botton_accionar;
	public static KeyCode cambiar_municion_pos;
	public static KeyCode cambiar_municion_neg;
	public static KeyCode mando_play_x;
	public static KeyCode mando_play_cuadrado;
	public static KeyCode mando_play_triangulo;





	public KeyCode Jump;
	public KeyCode Right;
	public KeyCode Left;
	public KeyCode Up;
	public KeyCode Down;
	public KeyCode Golpear;
	public KeyCode Accionar;
	public KeyCode CambMunPos;
	public KeyCode CambMunNeg;
	public KeyCode MandoPlayX;
	public KeyCode MandoPlayCuadrado;
	public KeyCode MandoPlayTriangulo;
	


	// Use this for initialization
	void Start () {

		botton_jumP = Jump;
		botton_right= Right;
		botton_left = Left;
		botton_up = Up;
		botton_down = Down;
		botton_golpear = Golpear;
		botton_accionar = Accionar;
		cambiar_municion_pos = CambMunPos;
		cambiar_municion_neg = CambMunNeg;
		mando_play_x = MandoPlayX;
		mando_play_cuadrado = MandoPlayCuadrado;
		mando_play_triangulo = MandoPlayTriangulo;
	}

	// Update is called once per frame
	void Update () {

	}
}