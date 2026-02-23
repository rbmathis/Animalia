using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Otothyropsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Otothyropsis.unclassified_Otothyropsis;

/// <summary>
/// Abstract class for unclassified Otothyropsis (no rank).
/// NCBI TaxId: 2618731
/// </summary>
public abstract class unclassified_Otothyropsis : Otothyropsis, Iunclassified_Otothyropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Otothyropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618731;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Otothyropsis";
}
