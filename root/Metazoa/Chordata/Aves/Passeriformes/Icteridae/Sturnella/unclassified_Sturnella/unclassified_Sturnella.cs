using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Sturnella;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Sturnella.unclassified_Sturnella;

/// <summary>
/// Abstract class for unclassified Sturnella (no rank).
/// NCBI TaxId: 2856181
/// </summary>
public abstract class unclassified_Sturnella : Sturnella, Iunclassified_Sturnella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sturnella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2856181;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sturnella";
}
