using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.unclassified_Tetraodontiformes;

/// <summary>
/// Abstract class for unclassified Tetraodontiformes (no rank).
/// NCBI TaxId: 725603
/// </summary>
public abstract class unclassified_Tetraodontiformes : Tetraodontiformes, Iunclassified_Tetraodontiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tetraodontiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725603;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tetraodontiformes";
}
