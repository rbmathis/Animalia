namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Cryptotis;

/// <summary>
/// Species: Cryptotis lacertosus
/// NCBI TaxId: 1743241
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cryptotis_lacertosus : Cryptotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cryptotis lacertosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cryptotis_lacertosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1743241;
}
