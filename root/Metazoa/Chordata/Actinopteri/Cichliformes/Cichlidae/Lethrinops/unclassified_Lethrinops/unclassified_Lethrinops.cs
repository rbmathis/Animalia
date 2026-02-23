using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lethrinops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lethrinops.unclassified_Lethrinops;

/// <summary>
/// Abstract class for unclassified Lethrinops (no rank).
/// NCBI TaxId: 2618892
/// </summary>
public abstract class unclassified_Lethrinops : Lethrinops, Iunclassified_Lethrinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lethrinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618892;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lethrinops";
}
