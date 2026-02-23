namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fluviphylacidae.Fluviphylax;

/// <summary>
/// Interface defining characteristics of Fluviphylax (genus).
/// </summary>
public interface IFluviphylax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
