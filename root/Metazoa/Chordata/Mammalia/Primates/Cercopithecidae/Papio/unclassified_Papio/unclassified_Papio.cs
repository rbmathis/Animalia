using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Papio;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Papio.unclassified_Papio;

/// <summary>
/// Abstract class for unclassified Papio (no rank).
/// NCBI TaxId: 2632072
/// </summary>
public abstract class unclassified_Papio : Papio, Iunclassified_Papio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Papio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632072;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Papio";
}
