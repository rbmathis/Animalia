using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Hylorina;

/// <summary>
/// Abstract class for Hylorina (genus).
/// NCBI TaxId: 247967
/// </summary>
public abstract class Hylorina : Alsodidae, IHylorina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylorina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247967;

    /// <inheritdoc />
    public virtual string GenusName => "Hylorina";

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
