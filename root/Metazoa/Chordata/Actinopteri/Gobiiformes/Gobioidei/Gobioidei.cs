using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobioidei;

/// <summary>
/// Abstract class for Gobioidei (suborder).
/// NCBI TaxId: 8219
/// </summary>
public abstract class Gobioidei : Gobiiformes, IGobioidei
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobioidei";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "suborder";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8219;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Gobioidei";
}
