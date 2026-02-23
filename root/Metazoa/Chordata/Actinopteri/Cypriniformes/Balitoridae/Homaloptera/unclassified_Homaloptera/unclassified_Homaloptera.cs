using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Homaloptera;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Homaloptera.unclassified_Homaloptera;

/// <summary>
/// Abstract class for unclassified Homaloptera (no rank).
/// NCBI TaxId: 2646349
/// </summary>
public abstract class unclassified_Homaloptera : Homaloptera, Iunclassified_Homaloptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Homaloptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646349;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Homaloptera";
}
