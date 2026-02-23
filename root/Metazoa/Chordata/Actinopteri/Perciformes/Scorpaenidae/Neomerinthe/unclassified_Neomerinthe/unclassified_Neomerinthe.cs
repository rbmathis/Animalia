using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Neomerinthe;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Neomerinthe.unclassified_Neomerinthe;

/// <summary>
/// Abstract class for unclassified Neomerinthe (no rank).
/// NCBI TaxId: 3060275
/// </summary>
public abstract class unclassified_Neomerinthe : Neomerinthe, Iunclassified_Neomerinthe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neomerinthe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3060275;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neomerinthe";
}
