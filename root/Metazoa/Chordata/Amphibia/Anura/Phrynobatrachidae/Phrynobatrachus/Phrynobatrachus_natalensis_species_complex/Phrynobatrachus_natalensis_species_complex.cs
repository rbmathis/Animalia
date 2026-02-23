using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus.Phrynobatrachus_natalensis_species_complex;

/// <summary>
/// Abstract class for Phrynobatrachus natalensis species complex (no rank).
/// NCBI TaxId: 745261
/// </summary>
public abstract class Phrynobatrachus_natalensis_species_complex : Phrynobatrachus, IPhrynobatrachus_natalensis_species_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynobatrachus natalensis species complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745261;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Phrynobatrachus_natalensis_species_complex";
}
