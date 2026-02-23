using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Salariopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Salariopsis.unclassified_Salariopsis;

/// <summary>
/// Abstract class for unclassified Salariopsis (no rank).
/// NCBI TaxId: 3036767
/// </summary>
public abstract class unclassified_Salariopsis : Salariopsis, Iunclassified_Salariopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salariopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3036767;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salariopsis";
}
