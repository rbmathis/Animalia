using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Pterois;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Pterois.unclassified_Pterois;

/// <summary>
/// Abstract class for unclassified Pterois (no rank).
/// NCBI TaxId: 2632183
/// </summary>
public abstract class unclassified_Pterois : Pterois, Iunclassified_Pterois
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pterois";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632183;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pterois";
}
