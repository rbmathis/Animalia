using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Taeniamia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Taeniamia.unclassified_Taeniamia;

/// <summary>
/// Abstract class for unclassified Taeniamia (no rank).
/// NCBI TaxId: 2639975
/// </summary>
public abstract class unclassified_Taeniamia : Taeniamia, Iunclassified_Taeniamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Taeniamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639975;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Taeniamia";
}
