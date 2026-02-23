using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.unclassified_Cercopithecinae;

/// <summary>
/// Abstract class for unclassified Cercopithecinae (no rank).
/// NCBI TaxId: 3074503
/// </summary>
public abstract class unclassified_Cercopithecinae : Cercopithecidae, Iunclassified_Cercopithecinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cercopithecinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3074503;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cercopithecinae";
}
