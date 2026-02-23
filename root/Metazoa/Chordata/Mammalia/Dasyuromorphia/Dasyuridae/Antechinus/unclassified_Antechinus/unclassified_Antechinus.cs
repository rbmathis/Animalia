using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Antechinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Antechinus.unclassified_Antechinus;

/// <summary>
/// Abstract class for unclassified Antechinus (no rank).
/// NCBI TaxId: 2633936
/// </summary>
public abstract class unclassified_Antechinus : Antechinus, Iunclassified_Antechinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Antechinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633936;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Antechinus";
}
