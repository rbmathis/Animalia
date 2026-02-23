using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Ichthyosaura;

/// <summary>
/// Abstract class for Ichthyosaura (genus).
/// NCBI TaxId: 339873
/// </summary>
public abstract class Ichthyosaura : Salamandridae, IIchthyosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichthyosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 339873;

    /// <inheritdoc />
    public virtual string GenusName => "Ichthyosaura";

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
