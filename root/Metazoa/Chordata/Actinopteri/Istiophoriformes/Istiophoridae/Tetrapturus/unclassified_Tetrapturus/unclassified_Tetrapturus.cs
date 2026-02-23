using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Tetrapturus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Tetrapturus.unclassified_Tetrapturus;

/// <summary>
/// Abstract class for unclassified Tetrapturus (no rank).
/// NCBI TaxId: 2622037
/// </summary>
public abstract class unclassified_Tetrapturus : Tetrapturus, Iunclassified_Tetrapturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tetrapturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622037;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tetrapturus";
}
