namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Piliocolobus;

/// <summary>
/// Species: Piliocolobus pennantii
/// NCBI TaxId: 591944
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Piliocolobus_pennantii : Piliocolobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Piliocolobus pennantii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Piliocolobus_pennantii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 591944;
}
