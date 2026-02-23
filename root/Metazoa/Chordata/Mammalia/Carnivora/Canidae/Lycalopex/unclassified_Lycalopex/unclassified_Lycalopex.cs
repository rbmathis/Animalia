using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Lycalopex;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Lycalopex.unclassified_Lycalopex;

/// <summary>
/// Abstract class for unclassified Lycalopex (no rank).
/// NCBI TaxId: 2639686
/// </summary>
public abstract class unclassified_Lycalopex : Lycalopex, Iunclassified_Lycalopex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lycalopex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639686;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lycalopex";
}
