using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chelonoidis;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chelonoidis.Chelonoidis_nigra_species_complex;

/// <summary>
/// Abstract class for Chelonoidis nigra species complex (no rank).
/// NCBI TaxId: 1137846
/// </summary>
public abstract class Chelonoidis_nigra_species_complex : Chelonoidis, IChelonoidis_nigra_species_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelonoidis nigra species complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1137846;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Chelonoidis_nigra_species_complex";
}
