using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Micropogonias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Micropogonias.unclassified_Micropogonias;

/// <summary>
/// Abstract class for unclassified Micropogonias (no rank).
/// NCBI TaxId: 2804336
/// </summary>
public abstract class unclassified_Micropogonias : Micropogonias, Iunclassified_Micropogonias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micropogonias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2804336;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micropogonias";
}
