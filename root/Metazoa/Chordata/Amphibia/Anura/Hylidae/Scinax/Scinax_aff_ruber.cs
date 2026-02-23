namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax aff. ruber
/// NCBI TaxId: 3446476
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_aff_ruber : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax aff. ruber";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_aff_ruber";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3446476;
}
