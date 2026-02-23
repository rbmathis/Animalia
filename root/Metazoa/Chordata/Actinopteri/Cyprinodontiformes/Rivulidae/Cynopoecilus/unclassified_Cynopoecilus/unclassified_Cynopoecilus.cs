using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Cynopoecilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Cynopoecilus.unclassified_Cynopoecilus;

/// <summary>
/// Abstract class for unclassified Cynopoecilus (no rank).
/// NCBI TaxId: 2638517
/// </summary>
public abstract class unclassified_Cynopoecilus : Cynopoecilus, Iunclassified_Cynopoecilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynopoecilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638517;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynopoecilus";
}
