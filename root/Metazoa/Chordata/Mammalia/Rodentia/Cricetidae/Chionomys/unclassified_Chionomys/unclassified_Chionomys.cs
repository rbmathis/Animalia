using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chionomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chionomys.unclassified_Chionomys;

/// <summary>
/// Abstract class for unclassified Chionomys (no rank).
/// NCBI TaxId: 2893897
/// </summary>
public abstract class unclassified_Chionomys : Chionomys, Iunclassified_Chionomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chionomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2893897;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chionomys";
}
