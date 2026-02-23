using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Astyanax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Astyanax.unclassified_Astyanax;

/// <summary>
/// Abstract class for unclassified Astyanax (no rank).
/// NCBI TaxId: 2602611
/// </summary>
public abstract class unclassified_Astyanax : Astyanax, Iunclassified_Astyanax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Astyanax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602611;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Astyanax";
}
