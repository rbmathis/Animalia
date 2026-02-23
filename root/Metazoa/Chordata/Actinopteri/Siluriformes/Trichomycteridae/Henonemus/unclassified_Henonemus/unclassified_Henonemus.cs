using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Henonemus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Henonemus.unclassified_Henonemus;

/// <summary>
/// Abstract class for unclassified Henonemus (no rank).
/// NCBI TaxId: 2624407
/// </summary>
public abstract class unclassified_Henonemus : Henonemus, Iunclassified_Henonemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Henonemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624407;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Henonemus";
}
