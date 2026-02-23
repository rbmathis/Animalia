using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Madascincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Madascincus.Madascincus_polleni_species_complex;

/// <summary>
/// Abstract class for Madascincus polleni species complex (no rank).
/// NCBI TaxId: 1073976
/// </summary>
public abstract class Madascincus_polleni_species_complex : Madascincus, IMadascincus_polleni_species_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Madascincus polleni species complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1073976;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Madascincus_polleni_species_complex";
}
