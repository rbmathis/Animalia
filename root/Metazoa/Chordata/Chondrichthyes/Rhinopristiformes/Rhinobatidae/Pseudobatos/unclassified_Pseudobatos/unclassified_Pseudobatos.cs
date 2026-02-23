using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Pseudobatos;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Pseudobatos.unclassified_Pseudobatos;

/// <summary>
/// Abstract class for unclassified Pseudobatos (no rank).
/// NCBI TaxId: 2636643
/// </summary>
public abstract class unclassified_Pseudobatos : Pseudobatos, Iunclassified_Pseudobatos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudobatos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636643;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudobatos";
}
