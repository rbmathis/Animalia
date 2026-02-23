using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scincella;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scincella.unclassified_Scincella;

/// <summary>
/// Abstract class for unclassified Scincella (no rank).
/// NCBI TaxId: 2623904
/// </summary>
public abstract class unclassified_Scincella : Scincella, Iunclassified_Scincella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scincella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623904;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scincella";
}
