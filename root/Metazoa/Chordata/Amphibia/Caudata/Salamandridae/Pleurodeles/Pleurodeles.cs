using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Pleurodeles;

/// <summary>
/// Abstract class for Pleurodeles (genus).
/// NCBI TaxId: 8317
/// </summary>
public abstract class Pleurodeles : Salamandridae, IPleurodeles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleurodeles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8317;

    /// <inheritdoc />
    public virtual string GenusName => "Pleurodeles";

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
