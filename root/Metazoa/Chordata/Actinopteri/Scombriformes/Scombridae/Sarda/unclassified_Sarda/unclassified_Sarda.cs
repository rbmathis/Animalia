using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Sarda;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Sarda.unclassified_Sarda;

/// <summary>
/// Abstract class for unclassified Sarda (no rank).
/// NCBI TaxId: 2634696
/// </summary>
public abstract class unclassified_Sarda : Sarda, Iunclassified_Sarda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sarda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634696;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sarda";
}
