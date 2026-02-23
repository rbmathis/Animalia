using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Hypoplectrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Hypoplectrus.unclassified_Hypoplectrus;

/// <summary>
/// Abstract class for unclassified Hypoplectrus (no rank).
/// NCBI TaxId: 2648642
/// </summary>
public abstract class unclassified_Hypoplectrus : Hypoplectrus, Iunclassified_Hypoplectrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypoplectrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648642;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypoplectrus";
}
