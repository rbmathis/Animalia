namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax v-signata
/// NCBI TaxId: 2493648
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_v_signata : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax v-signata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_v_signata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2493648;
}
