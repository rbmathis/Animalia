using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dispholidus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dispholidus.unclassified_Dispholidus;

/// <summary>
/// Abstract class for unclassified Dispholidus (no rank).
/// NCBI TaxId: 2635823
/// </summary>
public abstract class unclassified_Dispholidus : Dispholidus, Iunclassified_Dispholidus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dispholidus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635823;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dispholidus";
}
