namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Pyxis;

/// <summary>
/// Species: Pyxis arachnoides
/// NCBI TaxId: 66194
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyxis_arachnoides : Pyxis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyxis arachnoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyxis_arachnoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 66194;
}
