# The Ecosystem Project

As mentioned in the preface, one way to use this book is to build a single project over the course of reading it, incorporating elements from each chapter one step at a time. We’ll follow the development of an example project throughout this book—a simulation of an ecosystem. Imagine a population of computational creatures swimming around a digital pond, interacting with each other according to various rules.

## Chapter 1

Develop a set of rules for simulating the real-world behavior of a creature, such as a nervous fly, swimming fish, hopping bunny, slithering snake, etc. Can you control the object’s motion by only manipulating theƒ acceleration? Try to give the creature a personality through its behavior (rather than through its visual design).

## Chapter 2

Incorporate the concept of forces into your ecosystem. Try introducing other elements into the environment (food, a predator) for the creature to interact with. Does the creature experience attraction or repulsion to things in its world? Can you think more abstractly and design forces based on the creature’s desires or goals?

## Chapter 3

Take one of your creatures and incorporate oscillation into its motion. You can use the Oscillator class from Example 3.7 as a model. The Oscillator object, however, oscillates around a single point (the middle of the window). Try oscillating around a moving point. In other words, design a creature that moves around the screen according to location, velocity, and acceleration. But that creature isn’t just a static shape, it’s an oscillating body. Consider tying the speed of oscillation to the speed of motion. Think of a butterfly’s flapping wings or the legs of an insect. Can you make it appear that the creature’s internal mechanics (oscillation) drive its locomotion?

