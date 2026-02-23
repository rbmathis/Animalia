namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Salpa;

/// <summary>
/// Species: Salpa fusiformis
/// NCBI TaxId: 942554
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salpa_fusiformis : Salpa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salpa fusiformis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salpa_fusiformis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 942554;
}
