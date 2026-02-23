using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Pseudomyrophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Pseudomyrophis.unclassified_Pseudomyrophis;

/// <summary>
/// Abstract class for unclassified Pseudomyrophis (no rank).
/// NCBI TaxId: 2632955
/// </summary>
public abstract class unclassified_Pseudomyrophis : Pseudomyrophis, Iunclassified_Pseudomyrophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudomyrophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632955;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudomyrophis";
}
