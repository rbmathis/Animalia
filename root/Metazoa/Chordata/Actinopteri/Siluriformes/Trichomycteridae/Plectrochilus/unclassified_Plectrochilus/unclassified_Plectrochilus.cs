using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Plectrochilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Plectrochilus.unclassified_Plectrochilus;

/// <summary>
/// Abstract class for unclassified Plectrochilus (no rank).
/// NCBI TaxId: 2639124
/// </summary>
public abstract class unclassified_Plectrochilus : Plectrochilus, Iunclassified_Plectrochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plectrochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639124;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plectrochilus";
}
