namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Catopuma;

/// <summary>
/// Species: Catopuma temminckii
/// NCBI TaxId: 61455
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Catopuma_temminckii : Catopuma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Catopuma temminckii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Catopuma_temminckii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61455;
}
