using Godot;
using System;

public partial class Coin : Area2D
{
	[Export] public int Points { get; set; } = 1;

	private GameManager _gameManager;
	private AnimationPlayer _anim;

	public override void _Ready()
	{
		BodyEntered += OnBodyEntered;
		_gameManager = GetNode<GameManager>("%GameManager");
		_anim = GetNode<AnimationPlayer>("AnimationPlayer");
	}

	private void OnBodyEntered(Node2D body)
	{
		if (!body.IsInGroup("Player")) 
			return;

		_gameManager.AddPoints(Points);
		_anim.Play("pickup");
	}
}
