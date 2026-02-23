namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Alepisauridae.Anotopterus;

/// <summary>
/// Interface defining characteristics of Anotopterus (genus).
/// </summary>
public interface IAnotopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
