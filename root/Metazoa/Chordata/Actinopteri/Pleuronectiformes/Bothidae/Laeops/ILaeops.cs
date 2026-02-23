namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Laeops;

/// <summary>
/// Interface defining characteristics of Laeops (genus).
/// </summary>
public interface ILaeops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
