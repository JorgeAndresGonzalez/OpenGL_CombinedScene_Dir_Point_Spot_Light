//FRAGMENT SHADER
#version 330 core

//This is the shader for our light lamp object

out vec4 FragColor;

void main()
{
    //It's always red regardless of anything.
    FragColor = vec4(1.0, 0.0, 0.0, 1.0);
}
