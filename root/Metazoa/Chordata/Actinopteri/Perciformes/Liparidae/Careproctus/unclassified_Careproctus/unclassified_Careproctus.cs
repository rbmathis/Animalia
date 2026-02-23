using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Careproctus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Careproctus.unclassified_Careproctus;

/// <summary>
/// Abstract class for unclassified Careproctus (no rank).
/// NCBI TaxId: 2600264
/// </summary>
public abstract class unclassified_Careproctus : Careproctus, Iunclassified_Careproctus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Careproctus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2600264;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Careproctus";
}
