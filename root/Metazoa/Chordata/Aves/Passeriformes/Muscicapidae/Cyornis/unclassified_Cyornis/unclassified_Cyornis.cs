using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cyornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cyornis.unclassified_Cyornis;

/// <summary>
/// Abstract class for unclassified Cyornis (no rank).
/// NCBI TaxId: 2677174
/// </summary>
public abstract class unclassified_Cyornis : Cyornis, Iunclassified_Cyornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677174;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyornis";
}
