using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Terelabrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Terelabrus.unclassified_Terelabrus;

/// <summary>
/// Abstract class for unclassified Terelabrus (no rank).
/// NCBI TaxId: 2990644
/// </summary>
public abstract class unclassified_Terelabrus : Terelabrus, Iunclassified_Terelabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Terelabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990644;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Terelabrus";
}
