using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Hypophthalmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Hypophthalmus.unclassified_Hypophthalmus;

/// <summary>
/// Abstract class for unclassified Hypophthalmus (no rank).
/// NCBI TaxId: 2620206
/// </summary>
public abstract class unclassified_Hypophthalmus : Hypophthalmus, Iunclassified_Hypophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620206;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypophthalmus";
}
