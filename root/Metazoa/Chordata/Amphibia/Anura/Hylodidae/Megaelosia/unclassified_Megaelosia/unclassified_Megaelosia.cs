using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Megaelosia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Megaelosia.unclassified_Megaelosia;

/// <summary>
/// Abstract class for unclassified Megaelosia (no rank).
/// NCBI TaxId: 2731440
/// </summary>
public abstract class unclassified_Megaelosia : Megaelosia, Iunclassified_Megaelosia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megaelosia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2731440;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megaelosia";
}
