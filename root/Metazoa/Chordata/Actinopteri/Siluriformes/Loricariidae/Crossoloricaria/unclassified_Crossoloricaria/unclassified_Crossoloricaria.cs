using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Crossoloricaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Crossoloricaria.unclassified_Crossoloricaria;

/// <summary>
/// Abstract class for unclassified Crossoloricaria (no rank).
/// NCBI TaxId: 2636942
/// </summary>
public abstract class unclassified_Crossoloricaria : Crossoloricaria, Iunclassified_Crossoloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crossoloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636942;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crossoloricaria";
}
