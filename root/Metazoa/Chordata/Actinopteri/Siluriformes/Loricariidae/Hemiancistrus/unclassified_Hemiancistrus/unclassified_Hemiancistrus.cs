using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hemiancistrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hemiancistrus.unclassified_Hemiancistrus;

/// <summary>
/// Abstract class for unclassified Hemiancistrus (no rank).
/// NCBI TaxId: 2685178
/// </summary>
public abstract class unclassified_Hemiancistrus : Hemiancistrus, Iunclassified_Hemiancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemiancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685178;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemiancistrus";
}
