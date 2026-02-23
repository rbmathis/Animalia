namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Polycentridae.Polycentropsis;

/// <summary>
/// Interface defining characteristics of Polycentropsis (genus).
/// </summary>
public interface IPolycentropsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
