using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labirint
{
    class MazeGame
    {
        private MazeGame factory = null;

        public MazeGame CreateGame(MazeFactory factory)
        {
            this.factory = factory;
            MazeFactory aMaze = this.factory.MakeMaze();

            Room r1 = this.factory.MakeRoom(1);
            Room r2 = this.factory.MakeRoom(2);
            Room r3 = this.factory.MakeRoom(3);
            Room r4 = this.factory.MakeRoom(4);

            Door theDoor = this.factory.MakeDoor(r1, r2);
            Door theDoor2 = this.factory.MakeDoor(r2, r3);
            Door theDoor3 = this.factory.MakeDoor(r3, r4);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);
            aMaze.AddRoom(r3);

            r1.SetSide(Direction.North, this.factory.MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, this.factory.MakeWall());
            r1.SetSide(Direction.West, this.factory.MakeWall());

            r2.SetSide(Direction.North, theDoor2);
            r2.SetSide(Direction.East, this.factory.MakeWall());
            r2.SetSide(Direction.South, this.factory.MakeWall());
            r2.SetSide(Direction.West, theDoor);

            r3.SetSide(Direction.North, this.factory.MakeWall());
            r3.SetSide(Direction.East, theDoor3);
            r3.SetSide(Direction.South, theDoor2);
            r3.SetSide(Direction.West, this.factory.MakeWall());

            r4.SetSide(Direction.North, this.factory.MakeWall());
            r4.SetSide(Direction.East, this.factory.MakeWall);
            r4.SetSide(Direction.South, this.factory.MakeWall());
            r4.SetSide(Direction.West, theDoor3);

            return aMaze;
        }
    }
}
