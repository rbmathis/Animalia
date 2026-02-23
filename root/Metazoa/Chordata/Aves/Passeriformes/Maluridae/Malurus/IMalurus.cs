namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Malurus;

/// <summary>
/// Interface defining characteristics of Malurus (genus).
/// </summary>
public interface IMalurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
