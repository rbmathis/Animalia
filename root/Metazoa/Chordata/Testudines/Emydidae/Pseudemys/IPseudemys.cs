namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Pseudemys;

/// <summary>
/// Interface defining characteristics of Pseudemys (genus).
/// </summary>
public interface IPseudemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
