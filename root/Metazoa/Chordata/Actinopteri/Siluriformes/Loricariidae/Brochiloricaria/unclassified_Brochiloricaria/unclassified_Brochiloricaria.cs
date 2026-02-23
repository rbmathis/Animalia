using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Brochiloricaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Brochiloricaria.unclassified_Brochiloricaria;

/// <summary>
/// Abstract class for unclassified Brochiloricaria (no rank).
/// NCBI TaxId: 2624788
/// </summary>
public abstract class unclassified_Brochiloricaria : Brochiloricaria, Iunclassified_Brochiloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brochiloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624788;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brochiloricaria";
}
