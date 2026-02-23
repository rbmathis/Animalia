using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercopithecus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercopithecus.unclassified_Cercopithecus;

/// <summary>
/// Abstract class for unclassified Cercopithecus (no rank).
/// NCBI TaxId: 2618071
/// </summary>
public abstract class unclassified_Cercopithecus : Cercopithecus, Iunclassified_Cercopithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cercopithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618071;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cercopithecus";
}
