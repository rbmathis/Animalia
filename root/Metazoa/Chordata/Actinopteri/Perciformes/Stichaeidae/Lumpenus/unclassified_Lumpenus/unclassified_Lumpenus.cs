using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Lumpenus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Lumpenus.unclassified_Lumpenus;

/// <summary>
/// Abstract class for unclassified Lumpenus (no rank).
/// NCBI TaxId: 2619692
/// </summary>
public abstract class unclassified_Lumpenus : Lumpenus, Iunclassified_Lumpenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lumpenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619692;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lumpenus";
}
