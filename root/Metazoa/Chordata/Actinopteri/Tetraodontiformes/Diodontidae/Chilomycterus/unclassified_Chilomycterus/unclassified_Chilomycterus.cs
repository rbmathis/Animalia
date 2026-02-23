using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae.Chilomycterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae.Chilomycterus.unclassified_Chilomycterus;

/// <summary>
/// Abstract class for unclassified Chilomycterus (no rank).
/// NCBI TaxId: 2997183
/// </summary>
public abstract class unclassified_Chilomycterus : Chilomycterus, Iunclassified_Chilomycterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chilomycterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2997183;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chilomycterus";
}
