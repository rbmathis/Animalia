using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombropidae.unclassified_Scombropidae;

/// <summary>
/// Abstract class for unclassified Scombropidae (no rank).
/// NCBI TaxId: 3446946
/// </summary>
public abstract class unclassified_Scombropidae : Scombropidae, Iunclassified_Scombropidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scombropidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446946;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scombropidae";
}
