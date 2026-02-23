namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae.Eupetes;

/// <summary>
/// Interface defining characteristics of Eupetes (genus).
/// </summary>
public interface IEupetes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
