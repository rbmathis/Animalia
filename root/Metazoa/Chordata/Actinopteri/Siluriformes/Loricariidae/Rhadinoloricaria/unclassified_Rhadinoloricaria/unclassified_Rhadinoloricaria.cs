using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rhadinoloricaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rhadinoloricaria.unclassified_Rhadinoloricaria;

/// <summary>
/// Abstract class for unclassified Rhadinoloricaria (no rank).
/// NCBI TaxId: 2646910
/// </summary>
public abstract class unclassified_Rhadinoloricaria : Rhadinoloricaria, Iunclassified_Rhadinoloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhadinoloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646910;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhadinoloricaria";
}
