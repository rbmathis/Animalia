using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Propithecus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Propithecus.unclassified_Propithecus;

/// <summary>
/// Abstract class for unclassified Propithecus (no rank).
/// NCBI TaxId: 2677806
/// </summary>
public abstract class unclassified_Propithecus : Propithecus, Iunclassified_Propithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Propithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677806;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Propithecus";
}
