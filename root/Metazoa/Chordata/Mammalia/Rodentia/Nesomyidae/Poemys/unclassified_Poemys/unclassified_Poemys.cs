using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Poemys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Poemys.unclassified_Poemys;

/// <summary>
/// Abstract class for unclassified Poemys (no rank).
/// NCBI TaxId: 3447475
/// </summary>
public abstract class unclassified_Poemys : Poemys, Iunclassified_Poemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Poemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3447475;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Poemys";
}
