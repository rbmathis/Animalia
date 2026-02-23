using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Enyalioides;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Enyalioides.unclassified_Enyalioides;

/// <summary>
/// Abstract class for unclassified Enyalioides (no rank).
/// NCBI TaxId: 2629150
/// </summary>
public abstract class unclassified_Enyalioides : Enyalioides, Iunclassified_Enyalioides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Enyalioides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629150;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Enyalioides";
}
