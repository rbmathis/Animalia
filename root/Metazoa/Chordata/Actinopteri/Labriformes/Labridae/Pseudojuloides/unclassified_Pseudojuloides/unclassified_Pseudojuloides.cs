using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudojuloides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudojuloides.unclassified_Pseudojuloides;

/// <summary>
/// Abstract class for unclassified Pseudojuloides (no rank).
/// NCBI TaxId: 2627395
/// </summary>
public abstract class unclassified_Pseudojuloides : Pseudojuloides, Iunclassified_Pseudojuloides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudojuloides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627395;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudojuloides";
}
