using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Sparus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Sparus.unclassified_Sparus;

/// <summary>
/// Abstract class for unclassified Sparus (no rank).
/// NCBI TaxId: 2628003
/// </summary>
public abstract class unclassified_Sparus : Sparus, Iunclassified_Sparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628003;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sparus";
}
