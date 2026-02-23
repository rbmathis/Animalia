using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Dasyloricaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Dasyloricaria.unclassified_Dasyloricaria;

/// <summary>
/// Abstract class for unclassified Dasyloricaria (no rank).
/// NCBI TaxId: 3126355
/// </summary>
public abstract class unclassified_Dasyloricaria : Dasyloricaria, Iunclassified_Dasyloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dasyloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3126355;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dasyloricaria";
}
