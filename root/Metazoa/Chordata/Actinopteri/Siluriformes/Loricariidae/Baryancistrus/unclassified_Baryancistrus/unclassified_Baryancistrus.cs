using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Baryancistrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Baryancistrus.unclassified_Baryancistrus;

/// <summary>
/// Abstract class for unclassified Baryancistrus (no rank).
/// NCBI TaxId: 2630330
/// </summary>
public abstract class unclassified_Baryancistrus : Baryancistrus, Iunclassified_Baryancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Baryancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630330;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Baryancistrus";
}
