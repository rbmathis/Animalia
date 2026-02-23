namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Tarphops;

/// <summary>
/// Interface defining characteristics of Tarphops (genus).
/// </summary>
public interface ITarphops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
