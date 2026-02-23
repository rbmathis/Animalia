using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tropheops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tropheops.unclassified_Tropheops;

/// <summary>
/// Abstract class for unclassified Tropheops (no rank).
/// NCBI TaxId: 2626723
/// </summary>
public abstract class unclassified_Tropheops : Tropheops, Iunclassified_Tropheops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tropheops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626723;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tropheops";
}
