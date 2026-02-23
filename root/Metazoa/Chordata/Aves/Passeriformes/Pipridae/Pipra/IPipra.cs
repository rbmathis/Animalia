namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Pipra;

/// <summary>
/// Interface defining characteristics of Pipra (genus).
/// </summary>
public interface IPipra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
