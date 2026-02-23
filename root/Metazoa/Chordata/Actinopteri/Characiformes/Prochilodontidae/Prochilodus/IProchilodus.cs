namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Prochilodontidae.Prochilodus;

/// <summary>
/// Interface defining characteristics of Prochilodus (genus).
/// </summary>
public interface IProchilodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
