using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Litopterna.Macraucheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Litopterna.Macraucheniidae.Macrauchenia;

/// <summary>
/// Abstract class for Macrauchenia (genus).
/// NCBI TaxId: 1563126
/// </summary>
public abstract class Macrauchenia : Macraucheniidae, IMacrauchenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrauchenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1563126;

    /// <inheritdoc />
    public virtual string GenusName => "Macrauchenia";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
