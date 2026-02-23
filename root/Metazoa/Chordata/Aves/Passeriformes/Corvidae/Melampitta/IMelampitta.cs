namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Melampitta;

/// <summary>
/// Interface defining characteristics of Melampitta (genus).
/// </summary>
public interface IMelampitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
