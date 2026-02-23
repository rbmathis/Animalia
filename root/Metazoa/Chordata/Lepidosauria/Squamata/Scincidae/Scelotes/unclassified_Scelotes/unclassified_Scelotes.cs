using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scelotes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scelotes.unclassified_Scelotes;

/// <summary>
/// Abstract class for unclassified Scelotes (no rank).
/// NCBI TaxId: 2649037
/// </summary>
public abstract class unclassified_Scelotes : Scelotes, Iunclassified_Scelotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scelotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649037;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scelotes";
}
