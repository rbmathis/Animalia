using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Siphamia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Siphamia.unclassified_Siphamia;

/// <summary>
/// Abstract class for unclassified Siphamia (no rank).
/// NCBI TaxId: 2638216
/// </summary>
public abstract class unclassified_Siphamia : Siphamia, Iunclassified_Siphamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Siphamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638216;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Siphamia";
}
