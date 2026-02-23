namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Pinaroloxias;

/// <summary>
/// Interface defining characteristics of Pinaroloxias (genus).
/// </summary>
public interface IPinaroloxias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
