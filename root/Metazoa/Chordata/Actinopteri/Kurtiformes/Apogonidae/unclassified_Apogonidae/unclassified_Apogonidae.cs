using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.unclassified_Apogonidae;

/// <summary>
/// Abstract class for unclassified Apogonidae (no rank).
/// NCBI TaxId: 722543
/// </summary>
public abstract class unclassified_Apogonidae : Apogonidae, Iunclassified_Apogonidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apogonidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722543;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apogonidae";
}
