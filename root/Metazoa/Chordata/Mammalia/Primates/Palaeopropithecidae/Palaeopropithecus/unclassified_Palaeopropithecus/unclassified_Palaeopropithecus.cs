using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Palaeopropithecidae.Palaeopropithecus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Palaeopropithecidae.Palaeopropithecus.unclassified_Palaeopropithecus;

/// <summary>
/// Abstract class for unclassified Palaeopropithecus (no rank).
/// NCBI TaxId: 2619300
/// </summary>
public abstract class unclassified_Palaeopropithecus : Palaeopropithecus, Iunclassified_Palaeopropithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Palaeopropithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619300;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Palaeopropithecus";
}
