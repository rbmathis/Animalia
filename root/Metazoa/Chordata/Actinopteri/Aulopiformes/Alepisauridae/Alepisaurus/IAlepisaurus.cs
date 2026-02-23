namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Alepisauridae.Alepisaurus;

/// <summary>
/// Interface defining characteristics of Alepisaurus (genus).
/// </summary>
public interface IAlepisaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
