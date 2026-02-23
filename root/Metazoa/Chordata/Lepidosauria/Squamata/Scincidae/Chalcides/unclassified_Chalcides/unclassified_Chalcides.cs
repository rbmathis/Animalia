using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Chalcides;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Chalcides.unclassified_Chalcides;

/// <summary>
/// Abstract class for unclassified Chalcides (no rank).
/// NCBI TaxId: 2677100
/// </summary>
public abstract class unclassified_Chalcides : Chalcides, Iunclassified_Chalcides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chalcides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677100;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chalcides";
}
