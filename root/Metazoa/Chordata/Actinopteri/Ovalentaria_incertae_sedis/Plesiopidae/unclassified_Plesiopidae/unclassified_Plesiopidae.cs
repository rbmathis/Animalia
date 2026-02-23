using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.unclassified_Plesiopidae;

/// <summary>
/// Abstract class for unclassified Plesiopidae (no rank).
/// NCBI TaxId: 2582000
/// </summary>
public abstract class unclassified_Plesiopidae : Plesiopidae, Iunclassified_Plesiopidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plesiopidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2582000;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plesiopidae";
}
