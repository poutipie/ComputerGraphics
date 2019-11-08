
# C++ Renders for the Essay in Computer Graphics course
This folder contains some example opengl renders for the computer graphics essay

# Building
The scripts should be cross platform compatible and buildable with cmake as long as the following dependencies from the cmake file are met:

Headers:
* include_directories($ENV{GLFW_INCLUDE_DIR})
-> https://www.glfw.org/
* include_directories($ENV{GLM_INCLUDE_DIR})
-> https://glm.g-truc.net/0.9.9/index.html
* include_directories($ENV{GLAD_INCLUDE_DIR})
-> https://glad.dav1d.de/
* include_directories($ENV{LEARNOPENGL_INCLUDE_DIR})
-> https://github.com/JoeyDeVries/LearnOpenGL

**Link Opengl libraries** <br/>
* link_directories($ENV{GLFW_LIBARY})
-> https://www.glfw.org/
* link_directories($ENV{LEARNOPENGL_LIBRARY})
-> https://github.com/JoeyDeVries/LearnOpenGL

# Notice
There is a small hack where the shaders and resources are copied into build directory so it is necessary to rebuild cmake in order
to see changes in the shader (I know its ugly but I am lazy)
