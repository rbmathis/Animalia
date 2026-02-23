using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Nomeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Nomeidae.unclassified_Nomeidae;

/// <summary>
/// Abstract class for unclassified Nomeidae (no rank).
/// NCBI TaxId: 2734971
/// </summary>
public abstract class unclassified_Nomeidae : Nomeidae, Iunclassified_Nomeidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nomeidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2734971;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nomeidae";
}
