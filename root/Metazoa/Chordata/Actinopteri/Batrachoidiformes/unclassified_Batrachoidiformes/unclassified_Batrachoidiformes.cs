using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.unclassified_Batrachoidiformes;

/// <summary>
/// Abstract class for unclassified Batrachoidiformes (no rank).
/// NCBI TaxId: 740687
/// </summary>
public abstract class unclassified_Batrachoidiformes : Batrachoidiformes, Iunclassified_Batrachoidiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Batrachoidiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 740687;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Batrachoidiformes";
}
