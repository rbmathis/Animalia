using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.unclassified_Ophidiiformes;

/// <summary>
/// Abstract class for unclassified Ophidiiformes (no rank).
/// NCBI TaxId: 727667
/// </summary>
public abstract class unclassified_Ophidiiformes : Ophidiiformes, Iunclassified_Ophidiiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophidiiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727667;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophidiiformes";
}
