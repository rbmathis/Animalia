using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Farlowella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Farlowella.unclassified_Farlowella;

/// <summary>
/// Abstract class for unclassified Farlowella (no rank).
/// NCBI TaxId: 2634662
/// </summary>
public abstract class unclassified_Farlowella : Farlowella, Iunclassified_Farlowella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Farlowella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634662;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Farlowella";
}
