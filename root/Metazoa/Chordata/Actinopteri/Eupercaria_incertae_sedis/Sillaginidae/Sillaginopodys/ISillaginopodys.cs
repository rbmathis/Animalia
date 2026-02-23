namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillaginopodys;

/// <summary>
/// Interface defining characteristics of Sillaginopodys (genus).
/// </summary>
public interface ISillaginopodys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
