namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Papio;

/// <summary>
/// Species: Papio ursinus
/// NCBI TaxId: 36229
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Papio_ursinus : Papio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Papio ursinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Papio_ursinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36229;
}
