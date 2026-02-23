namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Pastor;

/// <summary>
/// Species: Pastor roseus
/// NCBI TaxId: 451427
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pastor_roseus : Pastor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pastor roseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pastor_roseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 451427;
}
