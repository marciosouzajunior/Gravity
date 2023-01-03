# Gravity :ringed_planet:

This is a Unity project that simulates space gravity. It implements the following gravity equation:

<img src="https://user-images.githubusercontent.com/3470856/210441244-a4e192a9-4556-47fc-83b4-b6f12277e1a9.png" width="250">

Where F is the force due to gravity, between two masses (m1 and m2), which are a distance r apart and G is the gravitational constant.

## Project Structure

- **Objects**:
  - *Player*: A cube that simulates a player in the space.
  - *Planet1*: A sphere with lower mass. 
  - *Planet2*:  A sphere with bigger mass.
- **Scripts**:
  - *PlayerController*: Used to control the player with keyboard arrows
  - *PlanetGravity*: Script attached to planets to calculate the formula and move the player

## Demo

https://user-images.githubusercontent.com/3470856/210441753-c04f5ca0-e114-4d5f-9e3f-b9fed09ce124.mp4
