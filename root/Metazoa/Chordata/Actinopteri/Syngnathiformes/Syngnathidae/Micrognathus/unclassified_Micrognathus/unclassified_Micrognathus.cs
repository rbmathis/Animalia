using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Micrognathus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Micrognathus.unclassified_Micrognathus;

/// <summary>
/// Abstract class for unclassified Micrognathus (no rank).
/// NCBI TaxId: 3446438
/// </summary>
public abstract class unclassified_Micrognathus : Micrognathus, Iunclassified_Micrognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micrognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446438;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micrognathus";
}
