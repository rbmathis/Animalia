namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae.Hypogeophis;

/// <summary>
/// Interface defining characteristics of Hypogeophis (genus).
/// </summary>
public interface IHypogeophis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
