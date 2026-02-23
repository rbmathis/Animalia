using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus.Phrynobatrachus_calcaratus_species_complex;

/// <summary>
/// Abstract class for Phrynobatrachus calcaratus species complex (no rank).
/// NCBI TaxId: 745259
/// </summary>
public abstract class Phrynobatrachus_calcaratus_species_complex : Phrynobatrachus, IPhrynobatrachus_calcaratus_species_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynobatrachus calcaratus species complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745259;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Phrynobatrachus_calcaratus_species_complex";
}
