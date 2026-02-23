using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.unclassified_Apogoninae;

/// <summary>
/// Abstract class for unclassified Apogoninae (no rank).
/// NCBI TaxId: 2613811
/// </summary>
public abstract class unclassified_Apogoninae : Apogonidae, Iunclassified_Apogoninae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apogoninae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613811;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apogoninae";
}
