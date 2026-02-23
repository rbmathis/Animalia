namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae.Mola;

/// <summary>
/// Interface defining characteristics of Mola (genus).
/// </summary>
public interface IMola
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
