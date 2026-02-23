namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cyathopharynx;

/// <summary>
/// Interface defining characteristics of Cyathopharynx (genus).
/// </summary>
public interface ICyathopharynx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
