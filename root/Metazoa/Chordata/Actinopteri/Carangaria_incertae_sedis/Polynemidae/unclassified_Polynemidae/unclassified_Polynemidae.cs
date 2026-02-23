using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.unclassified_Polynemidae;

/// <summary>
/// Abstract class for unclassified Polynemidae (no rank).
/// NCBI TaxId: 2613817
/// </summary>
public abstract class unclassified_Polynemidae : Polynemidae, Iunclassified_Polynemidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polynemidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613817;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polynemidae";
}
