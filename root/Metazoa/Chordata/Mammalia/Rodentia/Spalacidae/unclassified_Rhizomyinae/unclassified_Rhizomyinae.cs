using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.unclassified_Rhizomyinae;

/// <summary>
/// Abstract class for unclassified Rhizomyinae (no rank).
/// NCBI TaxId: 1002712
/// </summary>
public abstract class unclassified_Rhizomyinae : Spalacidae, Iunclassified_Rhizomyinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhizomyinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1002712;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhizomyinae";
}
