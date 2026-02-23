using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco.unclassified_Draco;

/// <summary>
/// Abstract class for unclassified Draco (no rank).
/// NCBI TaxId: 2641316
/// </summary>
public abstract class unclassified_Draco : Draco, Iunclassified_Draco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Draco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641316;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Draco";
}
