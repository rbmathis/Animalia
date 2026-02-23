using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Trachypithecus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Trachypithecus.unclassified_Trachypithecus;

/// <summary>
/// Abstract class for unclassified Trachypithecus (no rank).
/// NCBI TaxId: 2623509
/// </summary>
public abstract class unclassified_Trachypithecus : Trachypithecus, Iunclassified_Trachypithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachypithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623509;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachypithecus";
}
