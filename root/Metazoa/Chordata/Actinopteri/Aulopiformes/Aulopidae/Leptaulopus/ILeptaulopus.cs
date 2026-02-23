namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae.Leptaulopus;

/// <summary>
/// Interface defining characteristics of Leptaulopus (genus).
/// </summary>
public interface ILeptaulopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
