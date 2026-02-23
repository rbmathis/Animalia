namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Cyclopsetta;

/// <summary>
/// Interface defining characteristics of Cyclopsetta (genus).
/// </summary>
public interface ICyclopsetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
