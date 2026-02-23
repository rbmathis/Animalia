namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Pseudemys;

/// <summary>
/// Species: Pseudemys gorzugi
/// NCBI TaxId: 667124
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudemys_gorzugi : Pseudemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudemys gorzugi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudemys_gorzugi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 667124;
}
