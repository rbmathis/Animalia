using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Pherohapsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Pherohapsis.unclassified_Pherohapsis;

/// <summary>
/// Abstract class for unclassified Pherohapsis (no rank).
/// NCBI TaxId: 2624888
/// </summary>
public abstract class unclassified_Pherohapsis : Pherohapsis, Iunclassified_Pherohapsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pherohapsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624888;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pherohapsis";
}
