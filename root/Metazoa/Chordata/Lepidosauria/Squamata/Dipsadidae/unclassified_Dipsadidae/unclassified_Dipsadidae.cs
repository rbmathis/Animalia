using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.unclassified_Dipsadidae;

/// <summary>
/// Abstract class for unclassified Dipsadidae (no rank).
/// NCBI TaxId: 3003630
/// </summary>
public abstract class unclassified_Dipsadidae : Dipsadidae, Iunclassified_Dipsadidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dipsadidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3003630;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dipsadidae";
}
