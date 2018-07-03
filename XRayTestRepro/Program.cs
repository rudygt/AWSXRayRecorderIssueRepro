using System;
using System.Threading;
using Amazon.XRay.Recorder.Core;
using Amazon.XRay.Recorder.Core.Internal.Emitters;
using Xunit;

namespace XRayTestRepro
{
    public class Loop
    {
        public static void DoLoop()
        {
            int iterations = 1;            

            while (iterations < 100)
            {
                var marshaller = new JsonSegmentMarshaller();

                iterations++;            
            }
        }
    }


    public class Tests
    {        
        [Fact]   
        public void can_create_marshaller()
        {            
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller2()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller3()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller4()
        {
            Loop.DoLoop();
        }
    }

    public class Tests2
    {
        [Fact]
        public void can_create_marshaller()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller2()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller3()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller4()
        {
            Loop.DoLoop();
        }
    }

    public class Tests3
    {
        [Fact]
        public void can_create_marshaller()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller2()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller3()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller4()
        {
            Loop.DoLoop();
        }
    }

    public class Tests4
    {
        [Fact]
        public void can_create_marshaller()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller2()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller3()
        {
            Loop.DoLoop();
        }

        [Fact]
        public void can_create_marshaller4()
        {
            Loop.DoLoop();
        }
    }

    public class Tests5
    {
        [Fact]
        public void can_create_marshaller()
        {
            Loop.DoLoop();
        }
    }

    public class Tests6
    {
        [Fact]
        public void can_create_marshaller()
        {
            Loop.DoLoop();
        }
    }

    public class Tests7
    {
        [Fact]
        public void can_create_marshaller()
        {
            Loop.DoLoop();
        }
    }

    public class Tests8
    {
        [Fact]
        public void can_create_marshaller()
        {
            Loop.DoLoop();
        }
    }

}