using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Parexocoetus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Parexocoetus.unclassified_Parexocoetus;

/// <summary>
/// Abstract class for unclassified Parexocoetus (no rank).
/// NCBI TaxId: 3122173
/// </summary>
public abstract class unclassified_Parexocoetus : Parexocoetus, Iunclassified_Parexocoetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parexocoetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3122173;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parexocoetus";
}
