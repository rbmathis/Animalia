namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes.Megalopidae.Megalops;

/// <summary>
/// Interface defining characteristics of Megalops (genus).
/// </summary>
public interface IMegalops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
