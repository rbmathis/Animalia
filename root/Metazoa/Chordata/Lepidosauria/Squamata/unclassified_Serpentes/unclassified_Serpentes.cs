using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.unclassified_Serpentes;

/// <summary>
/// Abstract class for unclassified Serpentes (no rank).
/// NCBI TaxId: 1612431
/// </summary>
public abstract class unclassified_Serpentes : Squamata, Iunclassified_Serpentes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Serpentes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1612431;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Serpentes";
}
