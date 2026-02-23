namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae.Papasula;

/// <summary>
/// Interface defining characteristics of Papasula (genus).
/// </summary>
public interface IPapasula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
