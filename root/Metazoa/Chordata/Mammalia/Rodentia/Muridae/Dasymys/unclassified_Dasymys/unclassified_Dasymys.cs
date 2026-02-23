using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dasymys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dasymys.unclassified_Dasymys;

/// <summary>
/// Abstract class for unclassified Dasymys (no rank).
/// NCBI TaxId: 2640544
/// </summary>
public abstract class unclassified_Dasymys : Dasymys, Iunclassified_Dasymys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dasymys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640544;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dasymys";
}
