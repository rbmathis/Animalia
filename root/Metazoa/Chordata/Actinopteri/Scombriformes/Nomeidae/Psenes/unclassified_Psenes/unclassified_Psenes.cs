using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Nomeidae.Psenes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Nomeidae.Psenes.unclassified_Psenes;

/// <summary>
/// Abstract class for unclassified Psenes (no rank).
/// NCBI TaxId: 2638894
/// </summary>
public abstract class unclassified_Psenes : Psenes, Iunclassified_Psenes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psenes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psenes";
}
