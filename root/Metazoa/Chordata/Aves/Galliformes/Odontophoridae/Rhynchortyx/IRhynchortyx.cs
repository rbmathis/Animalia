namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Rhynchortyx;

/// <summary>
/// Interface defining characteristics of Rhynchortyx (genus).
/// </summary>
public interface IRhynchortyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
