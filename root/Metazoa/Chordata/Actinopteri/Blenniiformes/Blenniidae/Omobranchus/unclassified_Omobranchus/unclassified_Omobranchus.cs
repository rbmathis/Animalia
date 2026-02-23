using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Omobranchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Omobranchus.unclassified_Omobranchus;

/// <summary>
/// Abstract class for unclassified Omobranchus (no rank).
/// NCBI TaxId: 2805496
/// </summary>
public abstract class unclassified_Omobranchus : Omobranchus, Iunclassified_Omobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Omobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2805496;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Omobranchus";
}
