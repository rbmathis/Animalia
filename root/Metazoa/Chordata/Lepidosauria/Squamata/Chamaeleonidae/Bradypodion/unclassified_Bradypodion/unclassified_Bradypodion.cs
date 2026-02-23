using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Bradypodion;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Bradypodion.unclassified_Bradypodion;

/// <summary>
/// Abstract class for unclassified Bradypodion (no rank).
/// NCBI TaxId: 366451
/// </summary>
public abstract class unclassified_Bradypodion : Bradypodion, Iunclassified_Bradypodion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bradypodion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 366451;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bradypodion";
}
