using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Kalophrynus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Kalophrynus.unclassified_Kalophrynus;

/// <summary>
/// Abstract class for unclassified Kalophrynus (no rank).
/// NCBI TaxId: 2642421
/// </summary>
public abstract class unclassified_Kalophrynus : Kalophrynus, Iunclassified_Kalophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kalophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642421;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kalophrynus";
}
