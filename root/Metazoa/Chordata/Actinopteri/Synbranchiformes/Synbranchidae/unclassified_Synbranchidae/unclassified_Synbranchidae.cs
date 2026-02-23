using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.unclassified_Synbranchidae;

/// <summary>
/// Abstract class for unclassified Synbranchidae (no rank).
/// NCBI TaxId: 200932
/// </summary>
public abstract class unclassified_Synbranchidae : Synbranchidae, Iunclassified_Synbranchidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synbranchidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 200932;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synbranchidae";
}
