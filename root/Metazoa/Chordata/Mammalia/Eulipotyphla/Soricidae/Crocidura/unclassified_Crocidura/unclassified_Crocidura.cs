using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Crocidura.unclassified_Crocidura;

/// <summary>
/// Abstract class for unclassified Crocidura (no rank).
/// NCBI TaxId: 2622384
/// </summary>
public abstract class unclassified_Crocidura : Crocidura, Iunclassified_Crocidura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crocidura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622384;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crocidura";
}
