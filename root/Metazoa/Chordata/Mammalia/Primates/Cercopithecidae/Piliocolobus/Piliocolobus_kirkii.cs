namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Piliocolobus;

/// <summary>
/// Species: Piliocolobus kirkii
/// NCBI TaxId: 591937
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Piliocolobus_kirkii : Piliocolobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Piliocolobus kirkii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Piliocolobus_kirkii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 591937;
}
