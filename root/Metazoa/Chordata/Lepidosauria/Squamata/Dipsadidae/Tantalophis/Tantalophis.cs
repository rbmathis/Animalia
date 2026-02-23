using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tantalophis;

/// <summary>
/// Abstract class for Tantalophis (genus).
/// NCBI TaxId: 427738
/// </summary>
public abstract class Tantalophis : Dipsadidae, ITantalophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tantalophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 427738;

    /// <inheritdoc />
    public virtual string GenusName => "Tantalophis";

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
