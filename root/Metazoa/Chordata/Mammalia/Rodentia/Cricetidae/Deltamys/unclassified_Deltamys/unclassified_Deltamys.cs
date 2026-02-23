using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Deltamys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Deltamys.unclassified_Deltamys;

/// <summary>
/// Abstract class for unclassified Deltamys (no rank).
/// NCBI TaxId: 2630997
/// </summary>
public abstract class unclassified_Deltamys : Deltamys, Iunclassified_Deltamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Deltamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630997;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Deltamys";
}
