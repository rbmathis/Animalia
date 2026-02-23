using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus.unclassified_Microtus;

/// <summary>
/// Abstract class for unclassified Microtus (no rank).
/// NCBI TaxId: 2644413
/// </summary>
public abstract class unclassified_Microtus : Microtus, Iunclassified_Microtus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microtus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644413;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microtus";
}
