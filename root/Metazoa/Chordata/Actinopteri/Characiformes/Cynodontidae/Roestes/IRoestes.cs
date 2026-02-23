namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Cynodontidae.Roestes;

/// <summary>
/// Interface defining characteristics of Roestes (genus).
/// </summary>
public interface IRoestes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
