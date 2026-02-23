using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Venefica;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Venefica.unclassified_Venefica;

/// <summary>
/// Abstract class for unclassified Venefica (no rank).
/// NCBI TaxId: 2618297
/// </summary>
public abstract class unclassified_Venefica : Venefica, Iunclassified_Venefica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Venefica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618297;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Venefica";
}
