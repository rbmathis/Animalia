using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Allactaga;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Allactaga.unclassified_Allactaga;

/// <summary>
/// Abstract class for unclassified Allactaga (no rank).
/// NCBI TaxId: 2643764
/// </summary>
public abstract class unclassified_Allactaga : Allactaga, Iunclassified_Allactaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Allactaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643764;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Allactaga";
}
