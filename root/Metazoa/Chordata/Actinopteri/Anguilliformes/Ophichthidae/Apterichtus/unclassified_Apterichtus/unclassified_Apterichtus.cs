using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Apterichtus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Apterichtus.unclassified_Apterichtus;

/// <summary>
/// Abstract class for unclassified Apterichtus (no rank).
/// NCBI TaxId: 3378040
/// </summary>
public abstract class unclassified_Apterichtus : Apterichtus, Iunclassified_Apterichtus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apterichtus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3378040;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apterichtus";
}
