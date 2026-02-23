namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Callanthiidae.Grammatonotus;

/// <summary>
/// Interface defining characteristics of Grammatonotus (genus).
/// </summary>
public interface IGrammatonotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
