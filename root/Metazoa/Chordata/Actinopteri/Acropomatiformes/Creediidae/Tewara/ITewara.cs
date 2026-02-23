namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Tewara;

/// <summary>
/// Interface defining characteristics of Tewara (genus).
/// </summary>
public interface ITewara
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
