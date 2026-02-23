using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Eleutheronema;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Eleutheronema.unclassified_Eleutheronema;

/// <summary>
/// Abstract class for unclassified Eleutheronema (no rank).
/// NCBI TaxId: 2639518
/// </summary>
public abstract class unclassified_Eleutheronema : Eleutheronema, Iunclassified_Eleutheronema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eleutheronema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639518;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eleutheronema";
}
