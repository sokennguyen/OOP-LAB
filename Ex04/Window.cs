using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB.Ex4
{
    internal class Window
    {
        public int posX, posY, sizeX, sizeY, maxSizeX, maxSizeY, stepSize;
        public Window()
        {
            posX= 0;
            posY= 0;
            sizeX= 0;
            sizeY= 0;
            maxSizeX= 0;
            maxSizeY= 0;
            stepSize= 0;
        }
        public Window(int x, int y) : this ()
        {
            sizeX = x;
            sizeY = y;
            maxSizeX = x;
            maxSizeY = y;
            stepSize = 10;
        }
        public Window(int maxSizeX,int maxSizeY,int sizeX,int sizeY):this (0,0)
        {
            this.maxSizeX= maxSizeX;
            this.maxSizeY= maxSizeY;
            this.sizeX= sizeX;
            this.sizeY = sizeY;
        }
        public Window(int maxSizeX, int maxSizeY, int sizeX, int sizeY, int posX, int posY) : this(maxSizeX,maxSizeY,sizeX,sizeY)
        {
            this.posX = posX;
            this.posY = posY;
        }
        public Window(int maxSizeX, int maxSizeY, int sizeX, int sizeY, int posX, int posY, int stepSize) : this(maxSizeX, maxSizeY, sizeX, sizeY, posX, posY)
        {
            this.stepSize = stepSize;
        }

        public void MoveTo(int x,int y)
        {
            this.posX = x;
            this.posY = y;
        }
        public void MoveToCorner()
        {
            this.posX = 0;
            this.posY = 0;
        }
        public void MoveStepUp()
        {
            this.posY -= stepSize;
        }
        public void MoveStepDown()
        {
            this.posY += stepSize;
        }
        public void MoveStepRight()
        {
            this.posX += stepSize;
        }
        public void MoveStepLeft()
        {
            this.posX-=stepSize;
        }
        public void Minimize()
        {
            this.sizeX = 0;
            this.sizeY = 0;
        }
        public void Maximize()
        {
            this.sizeX = maxSizeX;
            this.sizeY = maxSizeY;
        }
        public void IncSize()
        {
            this.sizeX += stepSize;
            this.sizeY += stepSize;
        }
        public void DecSize()
        {
            this.sizeX -= stepSize;
            this.sizeY -= stepSize;
        }
    }
}
