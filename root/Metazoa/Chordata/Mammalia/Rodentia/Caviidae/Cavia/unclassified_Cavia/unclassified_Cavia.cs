using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Cavia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Cavia.unclassified_Cavia;

/// <summary>
/// Abstract class for unclassified Cavia (no rank).
/// NCBI TaxId: 2622580
/// </summary>
public abstract class unclassified_Cavia : Cavia, Iunclassified_Cavia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cavia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622580;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cavia";
}
