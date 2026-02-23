namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cyrtodactylus;

/// <summary>
/// Species: Cyrtodactylus eisenmanae
/// NCBI TaxId: 1234000
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyrtodactylus_eisenmanae : Cyrtodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyrtodactylus eisenmanae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyrtodactylus_eisenmanae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234000;
}
