namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Desmodilliscus;

/// <summary>
/// Interface defining characteristics of Desmodilliscus (genus).
/// </summary>
public interface IDesmodilliscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
