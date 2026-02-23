using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Bodianus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Bodianus.unclassified_Bodianus;

/// <summary>
/// Abstract class for unclassified Bodianus (no rank).
/// NCBI TaxId: 2754882
/// </summary>
public abstract class unclassified_Bodianus : Bodianus, Iunclassified_Bodianus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bodianus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2754882;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bodianus";
}
