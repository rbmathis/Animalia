namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Roeboides;

/// <summary>
/// Interface defining characteristics of Roeboides (genus).
/// </summary>
public interface IRoeboides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
