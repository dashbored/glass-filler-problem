# glass-filler-problem

My solution for the glass filling problem described in the [instructions](./PER12480I-2587-Exempelproblem-Graz-Sweden-AB.pdf)

Each tick of time (changable in the Settings file, default 0.0001 s), an amount of liquid will be added to the pyramids top glass.
If this glass is full, it will split the incoming amount in two and pass down one half on it's left until it finds a non-filled glass, and then it will proceed with the right side.

Does not work great for larger pyramids if you don't have a lot of time on your hands!
