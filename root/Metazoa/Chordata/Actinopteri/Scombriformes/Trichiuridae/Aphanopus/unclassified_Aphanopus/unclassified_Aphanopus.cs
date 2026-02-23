using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Aphanopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Aphanopus.unclassified_Aphanopus;

/// <summary>
/// Abstract class for unclassified Aphanopus (no rank).
/// NCBI TaxId: 2635311
/// </summary>
public abstract class unclassified_Aphanopus : Aphanopus, Iunclassified_Aphanopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aphanopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635311;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aphanopus";
}
