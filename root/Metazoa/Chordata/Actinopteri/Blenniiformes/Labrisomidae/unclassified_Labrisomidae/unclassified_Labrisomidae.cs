using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.unclassified_Labrisomidae;

/// <summary>
/// Abstract class for unclassified Labrisomidae (no rank).
/// NCBI TaxId: 721881
/// </summary>
public abstract class unclassified_Labrisomidae : Labrisomidae, Iunclassified_Labrisomidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Labrisomidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 721881;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Labrisomidae";
}
