using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Coryphophylax;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Coryphophylax.unclassified_Coryphophylax;

/// <summary>
/// Abstract class for unclassified Coryphophylax (no rank).
/// NCBI TaxId: 2644664
/// </summary>
public abstract class unclassified_Coryphophylax : Coryphophylax, Iunclassified_Coryphophylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coryphophylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644664;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coryphophylax";
}
