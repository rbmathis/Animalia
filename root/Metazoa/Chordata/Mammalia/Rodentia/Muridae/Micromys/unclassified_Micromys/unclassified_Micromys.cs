using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Micromys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Micromys.unclassified_Micromys;

/// <summary>
/// Abstract class for unclassified Micromys (no rank).
/// NCBI TaxId: 2898791
/// </summary>
public abstract class unclassified_Micromys : Micromys, Iunclassified_Micromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2898791;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micromys";
}
