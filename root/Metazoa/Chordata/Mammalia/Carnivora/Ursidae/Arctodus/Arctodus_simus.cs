namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Arctodus;

/// <summary>
/// Species: Arctodus simus
/// NCBI TaxId: 551196
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arctodus_simus : Arctodus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arctodus simus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arctodus_simus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 551196;
}
