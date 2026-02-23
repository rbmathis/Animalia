using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Myosorex;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Myosorex.unclassified_Myosorex;

/// <summary>
/// Abstract class for unclassified Myosorex (no rank).
/// NCBI TaxId: 2628471
/// </summary>
public abstract class unclassified_Myosorex : Myosorex, Iunclassified_Myosorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myosorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628471;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myosorex";
}
