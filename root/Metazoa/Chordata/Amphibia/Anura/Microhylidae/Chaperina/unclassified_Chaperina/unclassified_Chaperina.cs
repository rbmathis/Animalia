using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Chaperina;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Chaperina.unclassified_Chaperina;

/// <summary>
/// Abstract class for unclassified Chaperina (no rank).
/// NCBI TaxId: 2904678
/// </summary>
public abstract class unclassified_Chaperina : Chaperina, Iunclassified_Chaperina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaperina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2904678;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaperina";
}
