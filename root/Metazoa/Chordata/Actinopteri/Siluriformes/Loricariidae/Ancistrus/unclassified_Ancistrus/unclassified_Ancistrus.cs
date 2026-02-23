using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Ancistrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Ancistrus.unclassified_Ancistrus;

/// <summary>
/// Abstract class for unclassified Ancistrus (no rank).
/// NCBI TaxId: 2644411
/// </summary>
public abstract class unclassified_Ancistrus : Ancistrus, Iunclassified_Ancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644411;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ancistrus";
}
