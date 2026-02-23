using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pachyurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pachyurus.unclassified_Pachyurus;

/// <summary>
/// Abstract class for unclassified Pachyurus (no rank).
/// NCBI TaxId: 2648939
/// </summary>
public abstract class unclassified_Pachyurus : Pachyurus, Iunclassified_Pachyurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pachyurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648939;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pachyurus";
}
