namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Tarentola;

/// <summary>
/// Species: Tarentola boavistensis
/// NCBI TaxId: 130750
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tarentola_boavistensis : Tarentola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tarentola boavistensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tarentola_boavistensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 130750;
}
