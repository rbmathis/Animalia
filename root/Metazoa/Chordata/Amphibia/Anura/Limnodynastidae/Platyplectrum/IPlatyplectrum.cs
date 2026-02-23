namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Platyplectrum;

/// <summary>
/// Interface defining characteristics of Platyplectrum (genus).
/// </summary>
public interface IPlatyplectrum
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
