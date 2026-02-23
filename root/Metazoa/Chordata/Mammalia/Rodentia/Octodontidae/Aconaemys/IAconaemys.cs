namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Aconaemys;

/// <summary>
/// Interface defining characteristics of Aconaemys (genus).
/// </summary>
public interface IAconaemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
