using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bassanago;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bassanago.unclassified_Bassanago;

/// <summary>
/// Abstract class for unclassified Bassanago (no rank).
/// NCBI TaxId: 2980704
/// </summary>
public abstract class unclassified_Bassanago : Bassanago, Iunclassified_Bassanago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bassanago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2980704;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bassanago";
}
