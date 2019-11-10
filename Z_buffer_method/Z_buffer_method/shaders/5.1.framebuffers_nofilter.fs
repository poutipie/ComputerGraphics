#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D screenTexture;
uniform sampler2D depthTexture;

void main()
{
    // Make actual textures
    vec3 col_orig = texture(screenTexture, TexCoords).rgb;
    FragColor = vec4(col_orig, 1.0);
}