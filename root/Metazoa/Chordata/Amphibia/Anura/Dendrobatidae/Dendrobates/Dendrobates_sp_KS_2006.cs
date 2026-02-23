namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Dendrobates;

/// <summary>
/// Species: Dendrobates sp. KS-2006
/// NCBI TaxId: 370610
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendrobates_sp_KS_2006 : Dendrobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendrobates sp. KS-2006";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendrobates_sp_KS_2006";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 370610;
}
