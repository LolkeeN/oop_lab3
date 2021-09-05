using System;
using System.Collections.Generic;
using System.Text;

namespace Veselov_V_O_oop_lab3
{
    class CPoint : CGraphicsObject
    {
        private double radiusA;
        private double radiusB;
        private double degree;
        private double square;

        public CPoint(int x, int y) {
            this.radiusA = x;
            this.radiusB = y;
        }

        public CPoint() { }

        public double getRadiusA() {
            return radiusA;
        }
        public double getRadiusB() {
            return radiusB;
        } 
        public double getDegree() {
            return degree;
        }

        public double getSquare() {
            double square = Math.PI * radiusA * radiusB * (degree / 360);
            this.square = square;
            return square;
        }

        public void setRadiusA(double radiusA) {
            this.radiusA = radiusA;
        }
        public void setRadiusB(double radiusB) {
            this.radiusB = radiusB; 
        }  
        public void setDegree(double degree) {
            this.degree = degree;
        }

        public new void displayName() {
            Console.WriteLine("Sector: {name: '" + name + "', radiusA: '" + radiusA + "', radiusB: '"
                + radiusB + "', degree: '" + degree + "', " +
                "square: '" + square + "'");
        }
    }
}
