using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.unclassified_Pseudochromidae;

/// <summary>
/// Abstract class for unclassified Pseudochromidae (no rank).
/// NCBI TaxId: 1647141
/// </summary>
public abstract class unclassified_Pseudochromidae : Pseudochromidae, Iunclassified_Pseudochromidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudochromidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1647141;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudochromidae";
}
