# CMakeList.txt : CMake project for Stencil_method, include source and define
# project specific logic here.
#
cmake_minimum_required (VERSION 3.8)

# Add source to this project's executable.
string(REPLACE "\\" "/" GLAD_SRC $ENV{GLAD_SOURCE_FILE})
string(REPLACE "\\" "/" LEARNOPENGL_SRC $ENV{LEARNOPENGL_SOURCE_DIR})
add_executable (Stencil_method "Stencil_method.cpp" "Stencil_method.h" ${GLAD_SRC} ${LEARNOPENGL_SRC}/stb_image.cpp)

find_library( GLFW3_LIBRARY_DLL glfw3dll )
target_link_libraries(Stencil_method ${OPENGL_gl_LIBRARY} ${GLFW3_LIBRARY_DLL})
# TODO: Add tests and install targets if needed.

# Copy shaders and resources to build dir
message(STATUS "Copying the stuff")
FILE(COPY "shaders/2.stencil_single_color.fs" DESTINATION "${CMAKE_CURRENT_BINARY_DIR}/shaders")
FILE(COPY "shaders/2.stencil_testing.fs" DESTINATION "${CMAKE_CURRENT_BINARY_DIR}/shaders")
FILE(COPY "shaders/2.stencil_testing.vs" DESTINATION "${CMAKE_CURRENT_BINARY_DIR}/shaders")
FILE(COPY "resources/marble.jpg" DESTINATION "${CMAKE_CURRENT_BINARY_DIR}/resources")
FILE(COPY "resources/metal.png" DESTINATION "${CMAKE_CURRENT_BINARY_DIR}/resources")
message(STATUS "Stuff copied")
