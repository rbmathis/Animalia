using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Jaculus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Jaculus.unclassified_Jaculus;

/// <summary>
/// Abstract class for unclassified Jaculus (no rank).
/// NCBI TaxId: 2630635
/// </summary>
public abstract class unclassified_Jaculus : Jaculus, Iunclassified_Jaculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Jaculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630635;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Jaculus";
}
