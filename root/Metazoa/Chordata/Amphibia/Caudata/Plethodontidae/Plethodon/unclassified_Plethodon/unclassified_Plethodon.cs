using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Plethodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Plethodon.unclassified_Plethodon;

/// <summary>
/// Abstract class for unclassified Plethodon (no rank).
/// NCBI TaxId: 2638057
/// </summary>
public abstract class unclassified_Plethodon : Plethodon, Iunclassified_Plethodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plethodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638057;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plethodon";
}
