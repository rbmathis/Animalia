using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Geotriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Geotriidae.unclassified_Geotriidae;

/// <summary>
/// Abstract class for unclassified Geotriidae (no rank).
/// NCBI TaxId: 2748626
/// </summary>
public abstract class unclassified_Geotriidae : Geotriidae, Iunclassified_Geotriidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Geotriidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2748626;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Geotriidae";
}
