namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Ctenoluciidae.Ctenolucius;

/// <summary>
/// Interface defining characteristics of Ctenolucius (genus).
/// </summary>
public interface ICtenolucius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
