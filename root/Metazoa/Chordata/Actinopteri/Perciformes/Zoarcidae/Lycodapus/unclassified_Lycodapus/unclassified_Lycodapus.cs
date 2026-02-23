using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycodapus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycodapus.unclassified_Lycodapus;

/// <summary>
/// Abstract class for unclassified Lycodapus (no rank).
/// NCBI TaxId: 2649709
/// </summary>
public abstract class unclassified_Lycodapus : Lycodapus, Iunclassified_Lycodapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lycodapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649709;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lycodapus";
}
