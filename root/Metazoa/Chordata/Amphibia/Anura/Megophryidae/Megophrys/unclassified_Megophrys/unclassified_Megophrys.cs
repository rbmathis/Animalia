using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Megophrys;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Megophrys.unclassified_Megophrys;

/// <summary>
/// Abstract class for unclassified Megophrys (no rank).
/// NCBI TaxId: 2617957
/// </summary>
public abstract class unclassified_Megophrys : Megophrys, Iunclassified_Megophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617957;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megophrys";
}
