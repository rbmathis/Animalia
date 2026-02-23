using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Protomelas;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Protomelas.unclassified_Protomelas;

/// <summary>
/// Abstract class for unclassified Protomelas (no rank).
/// NCBI TaxId: 2640521
/// </summary>
public abstract class unclassified_Protomelas : Protomelas, Iunclassified_Protomelas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Protomelas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640521;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Protomelas";
}
