using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Eryx;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Eryx.unclassified_Eryx;

/// <summary>
/// Abstract class for unclassified Eryx (no rank).
/// NCBI TaxId: 3467902
/// </summary>
public abstract class unclassified_Eryx : Eryx, Iunclassified_Eryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467902;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eryx";
}
