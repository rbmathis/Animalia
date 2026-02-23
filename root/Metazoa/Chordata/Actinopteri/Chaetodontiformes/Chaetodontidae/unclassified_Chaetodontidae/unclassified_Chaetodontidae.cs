using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.unclassified_Chaetodontidae;

/// <summary>
/// Abstract class for unclassified Chaetodontidae (no rank).
/// NCBI TaxId: 1647125
/// </summary>
public abstract class unclassified_Chaetodontidae : Chaetodontidae, Iunclassified_Chaetodontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaetodontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1647125;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaetodontidae";
}
