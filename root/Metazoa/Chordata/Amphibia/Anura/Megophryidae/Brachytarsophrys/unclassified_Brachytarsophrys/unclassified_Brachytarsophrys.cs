using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Brachytarsophrys;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Brachytarsophrys.unclassified_Brachytarsophrys;

/// <summary>
/// Abstract class for unclassified Brachytarsophrys (no rank).
/// NCBI TaxId: 2866396
/// </summary>
public abstract class unclassified_Brachytarsophrys : Brachytarsophrys, Iunclassified_Brachytarsophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachytarsophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2866396;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachytarsophrys";
}
