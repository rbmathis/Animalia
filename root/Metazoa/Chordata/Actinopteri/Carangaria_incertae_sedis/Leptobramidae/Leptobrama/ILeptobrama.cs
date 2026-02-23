namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Leptobramidae.Leptobrama;

/// <summary>
/// Interface defining characteristics of Leptobrama (genus).
/// </summary>
public interface ILeptobrama
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
