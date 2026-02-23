using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae.Hystrix;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae.Hystrix.unclassified_Hystrix_in_rodents;

/// <summary>
/// Abstract class for unclassified Hystrix (in: rodents) (no rank).
/// NCBI TaxId: 2688572
/// </summary>
public abstract class unclassified_Hystrix_in_rodents : Hystrix, Iunclassified_Hystrix_in_rodents
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hystrix (in: rodents)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688572;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hystrix_in_rodents";
}
