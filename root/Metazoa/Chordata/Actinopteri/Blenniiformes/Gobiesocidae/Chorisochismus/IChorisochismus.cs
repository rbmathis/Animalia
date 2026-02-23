namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Chorisochismus;

/// <summary>
/// Interface defining characteristics of Chorisochismus (genus).
/// </summary>
public interface IChorisochismus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
