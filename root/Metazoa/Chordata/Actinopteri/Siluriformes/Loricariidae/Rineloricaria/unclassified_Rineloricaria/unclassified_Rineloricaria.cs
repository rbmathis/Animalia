using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rineloricaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rineloricaria.unclassified_Rineloricaria;

/// <summary>
/// Abstract class for unclassified Rineloricaria (no rank).
/// NCBI TaxId: 2644579
/// </summary>
public abstract class unclassified_Rineloricaria : Rineloricaria, Iunclassified_Rineloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rineloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644579;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rineloricaria";
}
