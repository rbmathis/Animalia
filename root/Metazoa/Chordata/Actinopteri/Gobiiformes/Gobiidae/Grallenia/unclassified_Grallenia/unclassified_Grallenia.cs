using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Grallenia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Grallenia.unclassified_Grallenia;

/// <summary>
/// Abstract class for unclassified Grallenia (no rank).
/// NCBI TaxId: 3111982
/// </summary>
public abstract class unclassified_Grallenia : Grallenia, Iunclassified_Grallenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Grallenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3111982;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Grallenia";
}
