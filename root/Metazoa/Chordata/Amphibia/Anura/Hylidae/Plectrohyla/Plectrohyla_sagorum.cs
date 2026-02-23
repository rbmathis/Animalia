namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Plectrohyla;

/// <summary>
/// Species: Plectrohyla sagorum
/// NCBI TaxId: 2488568
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plectrohyla_sagorum : Plectrohyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plectrohyla sagorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plectrohyla_sagorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2488568;
}
