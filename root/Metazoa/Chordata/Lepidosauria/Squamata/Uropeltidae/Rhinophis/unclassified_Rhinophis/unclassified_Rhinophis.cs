using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Rhinophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Rhinophis.unclassified_Rhinophis;

/// <summary>
/// Abstract class for unclassified Rhinophis (no rank).
/// NCBI TaxId: 2646802
/// </summary>
public abstract class unclassified_Rhinophis : Rhinophis, Iunclassified_Rhinophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646802;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinophis";
}
