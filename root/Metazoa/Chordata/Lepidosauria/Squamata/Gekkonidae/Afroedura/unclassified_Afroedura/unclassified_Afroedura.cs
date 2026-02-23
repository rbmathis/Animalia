using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Afroedura;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Afroedura.unclassified_Afroedura;

/// <summary>
/// Abstract class for unclassified Afroedura (no rank).
/// NCBI TaxId: 2617574
/// </summary>
public abstract class unclassified_Afroedura : Afroedura, Iunclassified_Afroedura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Afroedura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617574;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Afroedura";
}
