using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Selasphorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Selasphorus.unclassified_Selasphorus;

/// <summary>
/// Abstract class for unclassified Selasphorus (no rank).
/// NCBI TaxId: 2878410
/// </summary>
public abstract class unclassified_Selasphorus : Selasphorus, Iunclassified_Selasphorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Selasphorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878410;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Selasphorus";
}
