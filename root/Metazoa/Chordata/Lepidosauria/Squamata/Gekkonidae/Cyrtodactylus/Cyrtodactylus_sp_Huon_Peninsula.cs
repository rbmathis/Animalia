namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cyrtodactylus;

/// <summary>
/// Species: Cyrtodactylus sp. Huon Peninsula
/// NCBI TaxId: 1234415
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyrtodactylus_sp_Huon_Peninsula : Cyrtodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyrtodactylus sp. Huon Peninsula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyrtodactylus_sp_Huon_Peninsula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234415;
}
