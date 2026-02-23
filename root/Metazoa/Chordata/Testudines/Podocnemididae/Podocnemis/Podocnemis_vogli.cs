namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Podocnemis;

/// <summary>
/// Species: Podocnemis vogli
/// NCBI TaxId: 510618
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podocnemis_vogli : Podocnemis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podocnemis vogli";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podocnemis_vogli";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 510618;
}
