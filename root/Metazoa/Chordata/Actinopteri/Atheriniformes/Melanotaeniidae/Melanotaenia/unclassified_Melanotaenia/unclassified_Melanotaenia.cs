using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Melanotaenia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Melanotaenia.unclassified_Melanotaenia;

/// <summary>
/// Abstract class for unclassified Melanotaenia (no rank).
/// NCBI TaxId: 2628656
/// </summary>
public abstract class unclassified_Melanotaenia : Melanotaenia, Iunclassified_Melanotaenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanotaenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628656;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanotaenia";
}
