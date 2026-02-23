using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Marmorosphax;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Marmorosphax.unclassified_Marmorosphax;

/// <summary>
/// Abstract class for unclassified Marmorosphax (no rank).
/// NCBI TaxId: 2622232
/// </summary>
public abstract class unclassified_Marmorosphax : Marmorosphax, Iunclassified_Marmorosphax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Marmorosphax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622232;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Marmorosphax";
}
