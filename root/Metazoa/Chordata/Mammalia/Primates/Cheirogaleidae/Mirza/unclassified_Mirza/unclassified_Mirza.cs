using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Mirza;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Mirza.unclassified_Mirza;

/// <summary>
/// Abstract class for unclassified Mirza (no rank).
/// NCBI TaxId: 2628182
/// </summary>
public abstract class unclassified_Mirza : Mirza, Iunclassified_Mirza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mirza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628182;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mirza";
}
