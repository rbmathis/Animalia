namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Smilisca;

/// <summary>
/// Species: Smilisca manisorum
/// NCBI TaxId: 2919758
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Smilisca_manisorum : Smilisca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Smilisca manisorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Smilisca_manisorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2919758;
}
