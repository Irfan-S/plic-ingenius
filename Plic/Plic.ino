/** 
 *  Created by Syed Irfan Ahmed - irfansa1@ymail.com
 *  Copyright (C) Plic Inc. - All Rights Reserved.
 *  Proprietary and Confidential
 *  Written by Syed Irfan Ahmed
 *  
 */

#include "NewPing.h"


const int trigPinHead = 9;
const int echoPinHead = 10;
const int trigPinBody = 11;
const int echoPinBody = 12;
const int buzzer=13;

// defines variables
float distanceHead;
float distanceBody;

// Maximum distance we want to ping for (in centimeters).
#define MAX_DISTANCE 400
#define MAX_DELAY 3000

int cycles = 20;

// NewPing setup of pins and maximum distance.
NewPing sonarHead(trigPinHead, echoPinHead, MAX_DISTANCE);
NewPing sonarBody(trigPinBody, echoPinBody, MAX_DISTANCE);

void setup() 
{
  pinMode(buzzer, OUTPUT);
  Serial.begin(9600);
}

void loop() 
{
  // TODO use ping_median and see how that works.
  // Send ping, get distance in cm
  distanceHead = sonarHead.convert_cm(sonarHead.ping_median(cycles));
  distanceBody = sonarBody.convert_cm(sonarBody.ping_median(cycles));
 
  
  if (distanceBody >= 150 || distanceHead >=150 || distanceBody <= 2) 
  {
    Serial.println("Out of range");
    noTone(buzzer);
  }
  else 
  {

	/**
	REDACTED CODE, as we are currently in the process of patenting the algorithm involved
	**/

  }
  delay(MAX_DELAY);
}



