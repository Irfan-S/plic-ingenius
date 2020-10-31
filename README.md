# Plic

Taking an example of inGenius, it's a 24 hour hack where most participants are glued to their screen building awesome software. But this also comes with another highlight, that almost all of us sit around craning our neck over screens, which affects our posture heavily. 
As of 2020, [neck and back pain][ws] are two major health issues that are plaguing the world, and this has often been attributed due to the increasing use of our mobile devices and computers.

Plic is a posture monitoring system designed to attach to monitors and laptops. It monitors your posture via a system of sensors which create a spatial map of your posture. On detecting a slouch or neck craning, it notifies you in screen via the windows application we have made.

# Prototype features

  - Monitors posture and notifies with a sound as of now, currently working on incorporating bluetooth comms
  - Windows app ready and functional, currently working on connecting device to application


Before inGenius, we decided to build a solution for mobile devices as well and partnered with [Shiftfit.ch][tc] to build a mobile application for Android devices that monitors posture. You can read more about this app [here][plicly].

Our goal is to create a posture monitoring system that doesn't require you to charge and wear devices, but instead uses existing devices that you have and fixed devices that you can attach and forget about.

### Tech

Our tech stack:

* Arduino - Posture algorithms for the hardware device, built and deployed on an Arduino Mini!
* Firebase - Storing user-posture history for further analytics and customized reports
* WinForms - Windows application that runs as a service, optimized for thread efficiency and low-latency reporting




   [ws]: <https://www.practicalpainmanagement.com/patient/conditions/low-back-pain/about-back-spine-neck-shoulder-pain-statistics>
   [plicly]:<https://www.plicly.com>
   [tc]: <http://shiftfit.ch/>
  
