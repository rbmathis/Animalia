using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus.Phrynobatrachus_mababiensis_species_complex;

/// <summary>
/// Abstract class for Phrynobatrachus mababiensis species complex (no rank).
/// NCBI TaxId: 702845
/// </summary>
public abstract class Phrynobatrachus_mababiensis_species_complex : Phrynobatrachus, IPhrynobatrachus_mababiensis_species_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynobatrachus mababiensis species complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 702845;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Phrynobatrachus_mababiensis_species_complex";
}
