using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Anarchias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Anarchias.unclassified_Anarchias;

/// <summary>
/// Abstract class for unclassified Anarchias (no rank).
/// NCBI TaxId: 2638488
/// </summary>
public abstract class unclassified_Anarchias : Anarchias, Iunclassified_Anarchias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anarchias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638488;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anarchias";
}
