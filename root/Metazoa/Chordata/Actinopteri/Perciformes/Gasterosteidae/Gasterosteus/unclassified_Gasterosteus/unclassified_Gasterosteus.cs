using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Gasterosteus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Gasterosteus.unclassified_Gasterosteus;

/// <summary>
/// Abstract class for unclassified Gasterosteus (no rank).
/// NCBI TaxId: 2677279
/// </summary>
public abstract class unclassified_Gasterosteus : Gasterosteus, Iunclassified_Gasterosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gasterosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677279;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gasterosteus";
}
