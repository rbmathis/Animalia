namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Smilisca;

/// <summary>
/// Species: Smilisca baudinii
/// NCBI TaxId: 279982
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Smilisca_baudinii : Smilisca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Smilisca baudinii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Smilisca_baudinii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279982;
}
