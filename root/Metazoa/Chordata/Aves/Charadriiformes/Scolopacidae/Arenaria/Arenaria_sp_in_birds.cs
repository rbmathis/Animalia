namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Arenaria;

/// <summary>
/// Species: Arenaria sp. (in: birds)
/// NCBI TaxId: 2046111
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arenaria_sp_in_birds : Arenaria
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arenaria sp. (in: birds)";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arenaria_sp_in_birds";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2046111;
}
