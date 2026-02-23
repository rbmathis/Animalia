using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Rhinobatos;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Rhinobatos.unclassified_Rhinobatos;

/// <summary>
/// Abstract class for unclassified Rhinobatos (no rank).
/// NCBI TaxId: 2649115
/// </summary>
public abstract class unclassified_Rhinobatos : Rhinobatos, Iunclassified_Rhinobatos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinobatos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649115;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinobatos";
}
