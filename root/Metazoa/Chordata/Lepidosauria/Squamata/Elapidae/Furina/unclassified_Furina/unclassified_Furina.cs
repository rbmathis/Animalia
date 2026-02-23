using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Furina;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Furina.unclassified_Furina;

/// <summary>
/// Abstract class for unclassified Furina (no rank).
/// NCBI TaxId: 2835281
/// </summary>
public abstract class unclassified_Furina : Furina, Iunclassified_Furina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Furina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2835281;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Furina";
}
