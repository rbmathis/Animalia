namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Dermophiidae.Geotrypetes;

/// <summary>
/// Interface defining characteristics of Geotrypetes (genus).
/// </summary>
public interface IGeotrypetes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
