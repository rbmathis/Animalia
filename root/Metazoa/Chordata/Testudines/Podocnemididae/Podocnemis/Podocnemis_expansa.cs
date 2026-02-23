namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Podocnemis;

/// <summary>
/// Species: Podocnemis expansa
/// NCBI TaxId: 44507
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podocnemis_expansa : Podocnemis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podocnemis expansa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podocnemis_expansa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44507;
}
