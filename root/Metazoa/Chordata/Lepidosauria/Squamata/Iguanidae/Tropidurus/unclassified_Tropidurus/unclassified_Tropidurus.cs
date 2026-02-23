using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Tropidurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Tropidurus.unclassified_Tropidurus;

/// <summary>
/// Abstract class for unclassified Tropidurus (no rank).
/// NCBI TaxId: 2620829
/// </summary>
public abstract class unclassified_Tropidurus : Tropidurus, Iunclassified_Tropidurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tropidurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620829;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tropidurus";
}
