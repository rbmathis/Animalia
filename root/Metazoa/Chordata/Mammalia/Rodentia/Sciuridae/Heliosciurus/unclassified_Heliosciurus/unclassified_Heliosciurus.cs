using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Heliosciurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Heliosciurus.unclassified_Heliosciurus;

/// <summary>
/// Abstract class for unclassified Heliosciurus (no rank).
/// NCBI TaxId: 3056447
/// </summary>
public abstract class unclassified_Heliosciurus : Heliosciurus, Iunclassified_Heliosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heliosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3056447;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heliosciurus";
}
