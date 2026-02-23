namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax ictericus
/// NCBI TaxId: 699828
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_ictericus : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax ictericus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_ictericus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 699828;
}
