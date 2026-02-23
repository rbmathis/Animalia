using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Elassodiscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Elassodiscus.unclassified_Elassodiscus;

/// <summary>
/// Abstract class for unclassified Elassodiscus (no rank).
/// NCBI TaxId: 2735112
/// </summary>
public abstract class unclassified_Elassodiscus : Elassodiscus, Iunclassified_Elassodiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elassodiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2735112;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elassodiscus";
}
