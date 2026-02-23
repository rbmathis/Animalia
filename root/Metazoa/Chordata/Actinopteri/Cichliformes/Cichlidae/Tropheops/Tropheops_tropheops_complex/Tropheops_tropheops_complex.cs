using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tropheops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tropheops.Tropheops_tropheops_complex;

/// <summary>
/// Abstract class for Tropheops tropheops complex (no rank).
/// NCBI TaxId: 1905357
/// </summary>
public abstract class Tropheops_tropheops_complex : Tropheops, ITropheops_tropheops_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropheops tropheops complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1905357;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Tropheops_tropheops_complex";
}
