using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Cacajao;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Cacajao.unclassified_Cacajao;

/// <summary>
/// Abstract class for unclassified Cacajao (no rank).
/// NCBI TaxId: 2704456
/// </summary>
public abstract class unclassified_Cacajao : Cacajao, Iunclassified_Cacajao
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cacajao";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2704456;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cacajao";
}
