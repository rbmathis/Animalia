using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Xiphocheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Xiphocheilus.unclassified_Xiphocheilus;

/// <summary>
/// Abstract class for unclassified Xiphocheilus (no rank).
/// NCBI TaxId: 2896478
/// </summary>
public abstract class unclassified_Xiphocheilus : Xiphocheilus, Iunclassified_Xiphocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xiphocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2896478;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xiphocheilus";
}
