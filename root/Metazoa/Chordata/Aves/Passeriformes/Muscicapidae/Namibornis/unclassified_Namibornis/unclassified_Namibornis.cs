using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Namibornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Namibornis.unclassified_Namibornis;

/// <summary>
/// Abstract class for unclassified Namibornis (no rank).
/// NCBI TaxId: 2642539
/// </summary>
public abstract class unclassified_Namibornis : Namibornis, Iunclassified_Namibornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Namibornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642539;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Namibornis";
}
