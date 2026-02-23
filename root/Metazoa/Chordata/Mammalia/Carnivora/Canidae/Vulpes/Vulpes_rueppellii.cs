namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Vulpes;

/// <summary>
/// Species: Vulpes rueppellii
/// NCBI TaxId: 354189
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vulpes_rueppellii : Vulpes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vulpes rueppellii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vulpes_rueppellii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 354189;
}
