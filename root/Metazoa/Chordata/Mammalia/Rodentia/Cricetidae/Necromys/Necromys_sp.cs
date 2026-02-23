namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Necromys;

/// <summary>
/// Species: Necromys sp.
/// NCBI TaxId: 2116606
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Necromys_sp : Necromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Necromys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Necromys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2116606;
}
