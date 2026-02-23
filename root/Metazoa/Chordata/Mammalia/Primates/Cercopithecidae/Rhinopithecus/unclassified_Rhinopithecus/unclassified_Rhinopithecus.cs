using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Rhinopithecus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Rhinopithecus.unclassified_Rhinopithecus;

/// <summary>
/// Abstract class for unclassified Rhinopithecus (no rank).
/// NCBI TaxId: 2644350
/// </summary>
public abstract class unclassified_Rhinopithecus : Rhinopithecus, Iunclassified_Rhinopithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinopithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644350;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinopithecus";
}
