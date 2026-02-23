using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Typhlosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Typhlosaurus.unclassified_Typhlosaurus;

/// <summary>
/// Abstract class for unclassified Typhlosaurus (no rank).
/// NCBI TaxId: 2685100
/// </summary>
public abstract class unclassified_Typhlosaurus : Typhlosaurus, Iunclassified_Typhlosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Typhlosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685100;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Typhlosaurus";
}
