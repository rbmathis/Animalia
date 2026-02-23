using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.unclassified_Cirrhitidae;

/// <summary>
/// Abstract class for unclassified Cirrhitidae (no rank).
/// NCBI TaxId: 3446427
/// </summary>
public abstract class unclassified_Cirrhitidae : Cirrhitidae, Iunclassified_Cirrhitidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cirrhitidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446427;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cirrhitidae";
}
