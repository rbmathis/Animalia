using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Brookesia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Brookesia.unclassified_Brookesia;

/// <summary>
/// Abstract class for unclassified Brookesia (no rank).
/// NCBI TaxId: 2623021
/// </summary>
public abstract class unclassified_Brookesia : Brookesia, Iunclassified_Brookesia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brookesia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623021;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brookesia";
}
