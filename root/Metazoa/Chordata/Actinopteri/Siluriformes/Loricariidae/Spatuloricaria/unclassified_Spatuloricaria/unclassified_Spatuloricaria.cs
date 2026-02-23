using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Spatuloricaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Spatuloricaria.unclassified_Spatuloricaria;

/// <summary>
/// Abstract class for unclassified Spatuloricaria (no rank).
/// NCBI TaxId: 2632097
/// </summary>
public abstract class unclassified_Spatuloricaria : Spatuloricaria, Iunclassified_Spatuloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Spatuloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632097;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Spatuloricaria";
}
