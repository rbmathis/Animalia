using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae.Brachycephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae.Brachycephalus.unclassified_Brachycephalus;

/// <summary>
/// Abstract class for unclassified Brachycephalus (no rank).
/// NCBI TaxId: 2633125
/// </summary>
public abstract class unclassified_Brachycephalus : Brachycephalus, Iunclassified_Brachycephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachycephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633125;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachycephalus";
}
