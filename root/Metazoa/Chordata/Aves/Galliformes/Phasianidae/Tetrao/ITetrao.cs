namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tetrao;

/// <summary>
/// Interface defining characteristics of Tetrao (genus).
/// </summary>
public interface ITetrao
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
