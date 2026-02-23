namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Tachiramantis;

/// <summary>
/// Species: Tachiramantis douglasi
/// NCBI TaxId: 350004
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tachiramantis_douglasi : Tachiramantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tachiramantis douglasi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tachiramantis_douglasi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 350004;
}
