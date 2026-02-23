using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Rhabdamia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Rhabdamia.unclassified_Rhabdamia;

/// <summary>
/// Abstract class for unclassified Rhabdamia (no rank).
/// NCBI TaxId: 2631972
/// </summary>
public abstract class unclassified_Rhabdamia : Rhabdamia, Iunclassified_Rhabdamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhabdamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631972;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhabdamia";
}
