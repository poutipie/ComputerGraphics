#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D screenTexture;
uniform sampler2D depthTexture;

//const float offset = 1.0 / 300.0;  
//vec2 offset = 1.0 / textureSize(depthTexture, 0);
vec2 offset = vec2(1.0/300.0, 1.0/50.0);

void main()
{
    vec2 offsets[9] = vec2[](
        vec2(-offset[0],  offset[1]),  // top-left
        vec2( 0.0f,       offset[1]),  // top-center
        vec2( offset[0],  offset[1]),  // top-right
        vec2(-offset[0],  0.0f),       // center-left
        vec2( 0.0f,       0.0f),       // center-center
        vec2( offset[0],  0.0f),       // center-right
        vec2(-offset[0],  -offset[1]), // bottom-left
        vec2( 0.0f,       -offset[1]), // bottom-center
        vec2( offset[0],  -offset[1])  // bottom-right    
    );

    float kernel[9] = float[](
        1,   1, 1,
        1,  -8, 1,
        1,   1, 1
    );
    
    vec3 sampleTex[9];
    for(int i = 0; i < 9; i++)
    {
        sampleTex[i] = vec3(texture(depthTexture, TexCoords.st + offsets[i]));
        sampleTex[i] = vec3(sampleTex[i][0] / 3.0, sampleTex[i][0] / 3.0, sampleTex[i][0] / 3.0);
    }
    vec3 col = vec3(0.0);
    for(int i = 0; i < 9; i++)
        col += sampleTex[i] * kernel[i];
    
    // Make actual textures
    vec3 col_actual = texture(screenTexture, TexCoords).rgb;
    float depth = texture(depthTexture, TexCoords).r;
    vec3 col_depth = vec3(depth / 3.0, depth / 3.0, depth / 3.0);
    FragColor = vec4(col_depth, 1.0);
}