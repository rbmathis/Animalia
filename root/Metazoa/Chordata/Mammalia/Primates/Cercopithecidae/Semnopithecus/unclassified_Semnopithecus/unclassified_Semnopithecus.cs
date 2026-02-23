using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Semnopithecus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Semnopithecus.unclassified_Semnopithecus;

/// <summary>
/// Abstract class for unclassified Semnopithecus (no rank).
/// NCBI TaxId: 2632571
/// </summary>
public abstract class unclassified_Semnopithecus : Semnopithecus, Iunclassified_Semnopithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Semnopithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632571;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Semnopithecus";
}
