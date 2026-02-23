using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Notothenia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Notothenia.unclassified_Notothenia;

/// <summary>
/// Abstract class for unclassified Notothenia (no rank).
/// NCBI TaxId: 2714133
/// </summary>
public abstract class unclassified_Notothenia : Notothenia, Iunclassified_Notothenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Notothenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2714133;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Notothenia";
}
