using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.unclassified_Paralepididae;

/// <summary>
/// Abstract class for unclassified Paralepididae (no rank).
/// NCBI TaxId: 2023527
/// </summary>
public abstract class unclassified_Paralepididae : Paralepididae, Iunclassified_Paralepididae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paralepididae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2023527;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paralepididae";
}
