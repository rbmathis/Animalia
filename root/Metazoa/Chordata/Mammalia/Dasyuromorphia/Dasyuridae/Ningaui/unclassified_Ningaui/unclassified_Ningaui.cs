using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Ningaui;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Ningaui.unclassified_Ningaui;

/// <summary>
/// Abstract class for unclassified Ningaui (no rank).
/// NCBI TaxId: 2646772
/// </summary>
public abstract class unclassified_Ningaui : Ningaui, Iunclassified_Ningaui
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ningaui";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646772;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ningaui";
}
