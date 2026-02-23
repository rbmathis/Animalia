using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Marmosa;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Marmosa.unclassified_Stegomarmosa;

/// <summary>
/// Abstract class for unclassified Stegomarmosa (no rank).
/// NCBI TaxId: 3115259
/// </summary>
public abstract class unclassified_Stegomarmosa : Marmosa, Iunclassified_Stegomarmosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stegomarmosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3115259;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stegomarmosa";
}
