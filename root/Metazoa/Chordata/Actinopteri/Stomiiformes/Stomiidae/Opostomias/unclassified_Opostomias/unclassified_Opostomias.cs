using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Opostomias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Opostomias.unclassified_Opostomias;

/// <summary>
/// Abstract class for unclassified Opostomias (no rank).
/// NCBI TaxId: 2638526
/// </summary>
public abstract class unclassified_Opostomias : Opostomias, Iunclassified_Opostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Opostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638526;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Opostomias";
}
