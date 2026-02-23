using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Oxyropsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Oxyropsis.unclassified_Oxyropsis;

/// <summary>
/// Abstract class for unclassified Oxyropsis (no rank).
/// NCBI TaxId: 2637850
/// </summary>
public abstract class unclassified_Oxyropsis : Oxyropsis, Iunclassified_Oxyropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oxyropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637850;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oxyropsis";
}
