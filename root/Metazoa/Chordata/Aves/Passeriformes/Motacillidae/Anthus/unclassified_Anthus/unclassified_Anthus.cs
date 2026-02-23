using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Anthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Anthus.unclassified_Anthus;

/// <summary>
/// Abstract class for unclassified Anthus (no rank).
/// NCBI TaxId: 3231887
/// </summary>
public abstract class unclassified_Anthus : Anthus, Iunclassified_Anthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3231887;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anthus";
}
