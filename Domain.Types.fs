module Domain.Types

type Rank = // rows
    | Rank8
    | Rank7
    | Rank6
    | Rank5
    | Rank4
    | Rank3
    | Rank2
    | Rank1

type File = // lines
    | FileA
    | FileB
    | FileC
    | FileD
    | FileE
    | FileF
    | FileG
    | FileH

type Camp =
    | White
    | Black

type PieceKind =
    | King
    | Queen
    | Rook
    | Bishop
    | Knight
    | Pawn

type Position = { rank: Rank; file: File }

type Piece = { camp: Camp; kind: PieceKind }

type CellState =
    | Occupied of Piece
    | Empty

type Cell =
    { position: Position; state: CellState }

type GameStatus =
    | InProgress of Camp
    | Win of Camp

type GameState =
    { board: Cell list; status: GameStatus }
