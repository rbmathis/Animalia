namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cuora;

/// <summary>
/// Species: Cuora amboinensis
/// NCBI TaxId: 74909
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuora_amboinensis : Cuora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuora amboinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuora_amboinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 74909;
}
