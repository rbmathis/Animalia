using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Alticola;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Alticola.unclassified_Alticola;

/// <summary>
/// Abstract class for unclassified Alticola (no rank).
/// NCBI TaxId: 3417911
/// </summary>
public abstract class unclassified_Alticola : Alticola, Iunclassified_Alticola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alticola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3417911;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alticola";
}
