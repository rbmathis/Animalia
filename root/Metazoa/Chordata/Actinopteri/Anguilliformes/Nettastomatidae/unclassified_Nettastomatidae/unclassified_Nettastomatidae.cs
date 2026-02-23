using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.unclassified_Nettastomatidae;

/// <summary>
/// Abstract class for unclassified Nettastomatidae (no rank).
/// NCBI TaxId: 267677
/// </summary>
public abstract class unclassified_Nettastomatidae : Nettastomatidae, Iunclassified_Nettastomatidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nettastomatidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 267677;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nettastomatidae";
}
