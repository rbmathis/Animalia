using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Hydrosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Hydrosaurus.unclassified_Hydrosaurus;

/// <summary>
/// Abstract class for unclassified Hydrosaurus (no rank).
/// NCBI TaxId: 2620897
/// </summary>
public abstract class unclassified_Hydrosaurus : Hydrosaurus, Iunclassified_Hydrosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hydrosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620897;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hydrosaurus";
}
