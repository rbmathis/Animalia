using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Hypsiglena;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Hypsiglena.unclassified_Hypsiglena;

/// <summary>
/// Abstract class for unclassified Hypsiglena (no rank).
/// NCBI TaxId: 2617757
/// </summary>
public abstract class unclassified_Hypsiglena : Hypsiglena, Iunclassified_Hypsiglena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypsiglena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617757;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypsiglena";
}
