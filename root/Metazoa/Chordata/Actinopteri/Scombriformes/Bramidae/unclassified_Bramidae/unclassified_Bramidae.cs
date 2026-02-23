using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.unclassified_Bramidae;

/// <summary>
/// Abstract class for unclassified Bramidae (no rank).
/// NCBI TaxId: 994743
/// </summary>
public abstract class unclassified_Bramidae : Bramidae, Iunclassified_Bramidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bramidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 994743;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bramidae";
}
