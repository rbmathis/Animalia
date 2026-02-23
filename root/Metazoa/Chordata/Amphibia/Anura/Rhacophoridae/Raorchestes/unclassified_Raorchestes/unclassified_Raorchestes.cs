using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Raorchestes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Raorchestes.unclassified_Raorchestes;

/// <summary>
/// Abstract class for unclassified Raorchestes (no rank).
/// NCBI TaxId: 2625407
/// </summary>
public abstract class unclassified_Raorchestes : Raorchestes, Iunclassified_Raorchestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Raorchestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625407;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Raorchestes";
}
