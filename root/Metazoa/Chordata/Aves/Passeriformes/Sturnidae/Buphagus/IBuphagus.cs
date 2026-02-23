namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Buphagus;

/// <summary>
/// Interface defining characteristics of Buphagus (genus).
/// </summary>
public interface IBuphagus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
