using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.unclassified_Talpidae;

/// <summary>
/// Abstract class for unclassified Talpidae (no rank).
/// NCBI TaxId: 2726893
/// </summary>
public abstract class unclassified_Talpidae : Talpidae, Iunclassified_Talpidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Talpidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726893;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Talpidae";
}
