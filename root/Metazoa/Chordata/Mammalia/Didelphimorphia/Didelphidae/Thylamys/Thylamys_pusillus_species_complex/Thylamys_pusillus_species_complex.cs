using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Thylamys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Thylamys.Thylamys_pusillus_species_complex;

/// <summary>
/// Abstract class for Thylamys pusillus species complex (no rank).
/// NCBI TaxId: 866635
/// </summary>
public abstract class Thylamys_pusillus_species_complex : Thylamys, IThylamys_pusillus_species_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thylamys pusillus species complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 866635;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Thylamys_pusillus_species_complex";
}
