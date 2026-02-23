using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Pithecia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Pithecia.unclassified_Pithecia;

/// <summary>
/// Abstract class for unclassified Pithecia (no rank).
/// NCBI TaxId: 2646430
/// </summary>
public abstract class unclassified_Pithecia : Pithecia, Iunclassified_Pithecia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pithecia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646430;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pithecia";
}
