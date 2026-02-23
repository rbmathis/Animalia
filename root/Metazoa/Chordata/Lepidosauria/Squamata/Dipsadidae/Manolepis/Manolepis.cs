using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Manolepis;

/// <summary>
/// Abstract class for Manolepis (genus).
/// NCBI TaxId: 699586
/// </summary>
public abstract class Manolepis : Dipsadidae, IManolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Manolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699586;

    /// <inheritdoc />
    public virtual string GenusName => "Manolepis";

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
