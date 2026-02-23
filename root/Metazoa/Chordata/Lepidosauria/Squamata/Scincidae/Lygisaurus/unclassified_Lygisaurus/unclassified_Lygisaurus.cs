using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lygisaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lygisaurus.unclassified_Lygisaurus;

/// <summary>
/// Abstract class for unclassified Lygisaurus (no rank).
/// NCBI TaxId: 3386236
/// </summary>
public abstract class unclassified_Lygisaurus : Lygisaurus, Iunclassified_Lygisaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lygisaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3386236;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lygisaurus";
}
