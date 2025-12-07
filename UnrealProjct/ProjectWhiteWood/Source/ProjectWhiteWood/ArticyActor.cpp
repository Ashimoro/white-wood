// Fill out your copyright notice in the Description page of Project Settings.


#include "ArticyActor.h"

// Sets default values
AArticyActor::AArticyActor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AArticyActor::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AArticyActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

