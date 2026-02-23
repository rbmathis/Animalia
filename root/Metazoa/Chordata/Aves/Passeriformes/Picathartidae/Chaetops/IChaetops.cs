namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Picathartidae.Chaetops;

/// <summary>
/// Interface defining characteristics of Chaetops (genus).
/// </summary>
public interface IChaetops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
