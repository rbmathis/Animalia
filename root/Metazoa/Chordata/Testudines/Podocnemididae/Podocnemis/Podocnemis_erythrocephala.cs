namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Podocnemis;

/// <summary>
/// Species: Podocnemis erythrocephala
/// NCBI TaxId: 510619
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podocnemis_erythrocephala : Podocnemis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podocnemis erythrocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podocnemis_erythrocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 510619;
}
