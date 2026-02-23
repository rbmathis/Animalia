using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Metaloricaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Metaloricaria.unclassified_Metaloricaria;

/// <summary>
/// Abstract class for unclassified Metaloricaria (no rank).
/// NCBI TaxId: 3101874
/// </summary>
public abstract class unclassified_Metaloricaria : Metaloricaria, Iunclassified_Metaloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Metaloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101874;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Metaloricaria";
}
