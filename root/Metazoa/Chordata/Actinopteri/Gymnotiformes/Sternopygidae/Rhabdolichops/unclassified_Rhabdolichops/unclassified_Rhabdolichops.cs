using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Rhabdolichops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Rhabdolichops.unclassified_Rhabdolichops;

/// <summary>
/// Abstract class for unclassified Rhabdolichops (no rank).
/// NCBI TaxId: 2626436
/// </summary>
public abstract class unclassified_Rhabdolichops : Rhabdolichops, Iunclassified_Rhabdolichops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhabdolichops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626436;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhabdolichops";
}
