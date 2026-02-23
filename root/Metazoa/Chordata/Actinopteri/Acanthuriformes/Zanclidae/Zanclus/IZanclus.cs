namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Zanclidae.Zanclus;

/// <summary>
/// Interface defining characteristics of Zanclus (genus).
/// </summary>
public interface IZanclus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
