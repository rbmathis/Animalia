using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Zungaro;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Zungaro.unclassified_Zungaro;

/// <summary>
/// Abstract class for unclassified Zungaro (no rank).
/// NCBI TaxId: 2645447
/// </summary>
public abstract class unclassified_Zungaro : Zungaro, Iunclassified_Zungaro
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zungaro";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645447;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zungaro";
}
