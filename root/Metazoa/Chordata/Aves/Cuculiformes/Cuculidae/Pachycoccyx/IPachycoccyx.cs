namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Pachycoccyx;

/// <summary>
/// Interface defining characteristics of Pachycoccyx (genus).
/// </summary>
public interface IPachycoccyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
