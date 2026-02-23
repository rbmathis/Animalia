using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Rhabdosargus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Rhabdosargus.unclassified_Rhabdosargus;

/// <summary>
/// Abstract class for unclassified Rhabdosargus (no rank).
/// NCBI TaxId: 3081710
/// </summary>
public abstract class unclassified_Rhabdosargus : Rhabdosargus, Iunclassified_Rhabdosargus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhabdosargus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3081710;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhabdosargus";
}
