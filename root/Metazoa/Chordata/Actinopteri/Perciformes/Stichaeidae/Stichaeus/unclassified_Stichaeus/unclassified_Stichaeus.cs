using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Stichaeus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Stichaeus.unclassified_Stichaeus;

/// <summary>
/// Abstract class for unclassified Stichaeus (no rank).
/// NCBI TaxId: 2627532
/// </summary>
public abstract class unclassified_Stichaeus : Stichaeus, Iunclassified_Stichaeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stichaeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627532;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stichaeus";
}
