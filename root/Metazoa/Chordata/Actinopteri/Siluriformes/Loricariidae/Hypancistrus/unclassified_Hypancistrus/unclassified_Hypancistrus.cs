using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hypancistrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hypancistrus.unclassified_Hypancistrus;

/// <summary>
/// Abstract class for unclassified Hypancistrus (no rank).
/// NCBI TaxId: 2627927
/// </summary>
public abstract class unclassified_Hypancistrus : Hypancistrus, Iunclassified_Hypancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627927;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypancistrus";
}
