using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Cteniloricaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Cteniloricaria.unclassified_Cteniloricaria;

/// <summary>
/// Abstract class for unclassified Cteniloricaria (no rank).
/// NCBI TaxId: 3101836
/// </summary>
public abstract class unclassified_Cteniloricaria : Cteniloricaria, Iunclassified_Cteniloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cteniloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101836;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cteniloricaria";
}
