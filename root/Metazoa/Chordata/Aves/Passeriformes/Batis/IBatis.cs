namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Batis;

/// <summary>
/// Interface defining characteristics of Batis (genus).
/// </summary>
public interface IBatis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
