# CMakeList.txt : Top-level CMake project file, do global configuration
# and include sub-projects here.
#
cmake_minimum_required (VERSION 3.8)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

project ("OGL_training")

## OPENGL ##
find_package(OpenGL REQUIRED)

# Include Opengl libraries
include_directories($ENV{GLFW_INCLUDE_DIR})
include_directories($ENV{GLM_INCLUDE_DIR})
include_directories($ENV{GLAD_INCLUDE_DIR})
include_directories($ENV{LEARNOPENGL_INCLUDE_DIR})

# Link Opengl libraries
link_directories($ENV{GLFW_LIBARY})
link_directories($ENV{LEARNOPENGL_LIBRARY})

# Include sub-projects.
add_subdirectory ("Stencil_method")
