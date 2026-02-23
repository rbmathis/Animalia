namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Marmota;

/// <summary>
/// Species: Marmota caligata
/// NCBI TaxId: 93160
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Marmota_caligata : Marmota
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Marmota caligata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Marmota_caligata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 93160;
}
