namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax nasicus
/// NCBI TaxId: 318394
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_nasicus : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax nasicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_nasicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318394;
}
