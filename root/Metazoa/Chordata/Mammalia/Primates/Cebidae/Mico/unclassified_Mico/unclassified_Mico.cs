using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Mico;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Mico.unclassified_Mico;

/// <summary>
/// Abstract class for unclassified Mico (no rank).
/// NCBI TaxId: 2850015
/// </summary>
public abstract class unclassified_Mico : Mico, Iunclassified_Mico
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mico";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2850015;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mico";
}
