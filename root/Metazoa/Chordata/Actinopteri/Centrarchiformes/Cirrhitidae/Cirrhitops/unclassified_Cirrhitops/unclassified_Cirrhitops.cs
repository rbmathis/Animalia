using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Cirrhitops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Cirrhitops.unclassified_Cirrhitops;

/// <summary>
/// Abstract class for unclassified Cirrhitops (no rank).
/// NCBI TaxId: 2623017
/// </summary>
public abstract class unclassified_Cirrhitops : Cirrhitops, Iunclassified_Cirrhitops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cirrhitops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623017;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cirrhitops";
}
