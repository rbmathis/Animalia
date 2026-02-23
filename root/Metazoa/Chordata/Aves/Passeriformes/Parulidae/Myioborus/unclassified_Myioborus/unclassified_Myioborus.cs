using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Myioborus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Myioborus.unclassified_Myioborus;

/// <summary>
/// Abstract class for unclassified Myioborus (no rank).
/// NCBI TaxId: 2913703
/// </summary>
public abstract class unclassified_Myioborus : Myioborus, Iunclassified_Myioborus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myioborus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2913703;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myioborus";
}
