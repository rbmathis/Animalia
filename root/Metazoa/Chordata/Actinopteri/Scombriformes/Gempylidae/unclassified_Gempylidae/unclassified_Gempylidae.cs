using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.unclassified_Gempylidae;

/// <summary>
/// Abstract class for unclassified Gempylidae (no rank).
/// NCBI TaxId: 2734950
/// </summary>
public abstract class unclassified_Gempylidae : Gempylidae, Iunclassified_Gempylidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gempylidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2734950;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gempylidae";
}
