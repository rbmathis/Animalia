using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Boulenophrys;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Boulenophrys.unclassified_Boulenophrys;

/// <summary>
/// Abstract class for unclassified Boulenophrys (no rank).
/// NCBI TaxId: 2933982
/// </summary>
public abstract class unclassified_Boulenophrys : Boulenophrys, Iunclassified_Boulenophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boulenophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2933982;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boulenophrys";
}
