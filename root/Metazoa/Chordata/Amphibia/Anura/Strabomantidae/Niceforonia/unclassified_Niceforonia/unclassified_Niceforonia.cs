using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Niceforonia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Niceforonia.unclassified_Niceforonia;

/// <summary>
/// Abstract class for unclassified Niceforonia (no rank).
/// NCBI TaxId: 2632899
/// </summary>
public abstract class unclassified_Niceforonia : Niceforonia, Iunclassified_Niceforonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Niceforonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632899;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Niceforonia";
}
