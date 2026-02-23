namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Smilisca;

/// <summary>
/// Species: Smilisca puma
/// NCBI TaxId: 318397
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Smilisca_puma : Smilisca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Smilisca puma";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Smilisca_puma";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318397;
}
