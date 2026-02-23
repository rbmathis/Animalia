namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cyrtodactylus;

/// <summary>
/// Species: Cyrtodactylus paradoxus
/// NCBI TaxId: 752000
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyrtodactylus_paradoxus : Cyrtodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyrtodactylus paradoxus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyrtodactylus_paradoxus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 752000;
}
