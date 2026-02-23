using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Atelomycterus;

/// <summary>
/// Abstract class for Atelomycterus (genus).
/// NCBI TaxId: 496080
/// </summary>
public abstract class Atelomycterus : Scyliorhinidae, IAtelomycterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atelomycterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 496080;

    /// <inheritdoc />
    public virtual string GenusName => "Atelomycterus";

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
