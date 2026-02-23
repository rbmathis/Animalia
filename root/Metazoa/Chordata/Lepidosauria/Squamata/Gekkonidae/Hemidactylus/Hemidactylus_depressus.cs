namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemidactylus;

/// <summary>
/// Species: Hemidactylus depressus
/// NCBI TaxId: 863651
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemidactylus_depressus : Hemidactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemidactylus depressus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemidactylus_depressus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 863651;
}
