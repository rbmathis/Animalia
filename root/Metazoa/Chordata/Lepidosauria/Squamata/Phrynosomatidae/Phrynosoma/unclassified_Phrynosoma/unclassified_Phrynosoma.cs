using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Phrynosoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Phrynosoma.unclassified_Phrynosoma;

/// <summary>
/// Abstract class for unclassified Phrynosoma (no rank).
/// NCBI TaxId: 2622460
/// </summary>
public abstract class unclassified_Phrynosoma : Phrynosoma, Iunclassified_Phrynosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phrynosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622460;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phrynosoma";
}
