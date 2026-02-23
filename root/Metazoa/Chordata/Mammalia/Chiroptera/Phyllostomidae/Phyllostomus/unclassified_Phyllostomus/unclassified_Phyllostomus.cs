using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Phyllostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Phyllostomus.unclassified_Phyllostomus;

/// <summary>
/// Abstract class for unclassified Phyllostomus (no rank).
/// NCBI TaxId: 2628851
/// </summary>
public abstract class unclassified_Phyllostomus : Phyllostomus, Iunclassified_Phyllostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628851;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllostomus";
}
