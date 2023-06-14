using Damas;

namespace Damas { 

    public class CapturePieceCommand : ICommand {

        private Receiver receiver;
        private int x;
        private int y;

        public CapturePieceCommand(Receiver receiver, int x, int y) {

            this.receiver = receiver;
            this.x = x;
            this.y = y;
        }

        public void Execute() {

            receiver.CapturePiece(x, y);
        }
    }

    public class MovePieceCommand : ICommand {

        private Receiver receiver;
        private int x;
        private int y;

        public MovePieceCommand(Receiver receiver, int x, int y) {

            this.receiver = receiver;
            this.x = x;
            this.y = y;
        }

        public void Execute() {

            receiver.MovePiece(x, y);
        }
    }

    public class JumpCommand : ICommand {

        private Receiver receiver;
        private List<Position> jumpPositions;

        public JumpCommand(Receiver receiver, List<Position> jumpPositions) {

            this.receiver = receiver;
            this.jumpPositions = jumpPositions;
        }

        public void Execute() {

            foreach (Position jumpPosition in jumpPositions) {

                receiver.Jump(jumpPosition.x, jumpPosition.y);
            }
        }
    }

    public class PromoteToDamaCommand : ICommand {

        private Receiver receiver;

        public PromoteToDamaCommand(Receiver receiver) {

            this.receiver = receiver;
        }

        public void Execute() {

            receiver.PromoteToDama();
        }
    }

    public class MoveDamaCommand : ICommand {

        private Receiver receiver;
        private int x;
        private int y;

        public MoveDamaCommand(Receiver receiver, int x, int y) {

            this.receiver = receiver;
            this.x = x;
            this.y = y;
        }

        public void Execute() {

            receiver.MoveDama(x, y);
        }
    }
}

]~~~]