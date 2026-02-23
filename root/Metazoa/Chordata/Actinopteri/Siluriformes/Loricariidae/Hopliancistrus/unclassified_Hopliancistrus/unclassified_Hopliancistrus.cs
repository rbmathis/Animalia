using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hopliancistrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hopliancistrus.unclassified_Hopliancistrus;

/// <summary>
/// Abstract class for unclassified Hopliancistrus (no rank).
/// NCBI TaxId: 2639201
/// </summary>
public abstract class unclassified_Hopliancistrus : Hopliancistrus, Iunclassified_Hopliancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hopliancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639201;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hopliancistrus";
}
