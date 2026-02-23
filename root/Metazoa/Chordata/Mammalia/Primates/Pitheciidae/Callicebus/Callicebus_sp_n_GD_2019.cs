namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Callicebus;

/// <summary>
/// Species: Callicebus sp. n. GD-2019
/// NCBI TaxId: 2650809
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Callicebus_sp_n_GD_2019 : Callicebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Callicebus sp. n. GD-2019";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Callicebus_sp_n_GD_2019";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2650809;
}
