# Gravity :ringed_planet:

This is a Unity project that simulates space gravity. It implements the following gravity equation:

<img src="https://user-images.githubusercontent.com/3470856/210441244-a4e192a9-4556-47fc-83b4-b6f12277e1a9.png" width="250">

Where F is the force due to gravity, between two masses (m1 and m2), which are a distance r apart and G is the gravitational constant.

## How it works

The PlanetGravity script must be attached to an object the will exert gravity force. Then set property "Object to Attrach" with the object to apply the force.

## Orbit

An object can be put in orbit by setting the property Orbity to true:

![image](https://user-images.githubusercontent.com/3470856/211054555-db233816-58fa-492c-a545-6760a7e61324.png)

In this case the following equation will be applyed to calculate the object velocity:

![image](https://user-images.githubusercontent.com/3470856/211055254-bf1edb85-a72e-4de2-b229-2f2cb5c324c0.png)

The direction of the object velocity always points along a tangent to its orbital path (blue line). And the planet gravity acts as a centripetal force (red line).

![image](https://user-images.githubusercontent.com/3470856/211056695-fe0ad0dc-9165-4e7e-9270-5705ed137a53.png)

The magnitude of the velocity does not change due to gravity, but the direction constantly changes because the gravitational force constantly redirects it along a circular path. At any point in the orbit, the directions of the two quantities always point at a right angle, or 90 degress,to each other.

## Demo

![gif_animation_006](https://user-images.githubusercontent.com/3470856/211053144-12f50b07-6887-4067-9a7c-8d9408b26a0b.gif)

## References

* https://www.nagwa.com/en/explainers/765154391754/
* https://www.nagwa.com/en/explainers/142168516704/
* https://www.youtube.com/watch?v=Ouu3D_VHx9o
* https://www.youtube.com/watch?v=kUXskc76ud8

