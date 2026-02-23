using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca.unclassified_Macaca;

/// <summary>
/// Abstract class for unclassified Macaca (no rank).
/// NCBI TaxId: 2623225
/// </summary>
public abstract class unclassified_Macaca : Macaca, Iunclassified_Macaca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macaca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623225;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macaca";
}
