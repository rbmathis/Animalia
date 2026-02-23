namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycephala;

/// <summary>
/// Interface defining characteristics of Pachycephala (genus).
/// </summary>
public interface IPachycephala
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
