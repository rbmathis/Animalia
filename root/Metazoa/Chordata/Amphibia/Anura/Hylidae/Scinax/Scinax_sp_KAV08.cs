namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax sp. KAV08
/// NCBI TaxId: 3045478
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_sp_KAV08 : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax sp. KAV08";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_sp_KAV08";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3045478;
}
