using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Phyllonemus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Phyllonemus.unclassified_Phyllonemus;

/// <summary>
/// Abstract class for unclassified Phyllonemus (no rank).
/// NCBI TaxId: 2641061
/// </summary>
public abstract class unclassified_Phyllonemus : Phyllonemus, Iunclassified_Phyllonemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllonemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641061;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllonemus";
}
