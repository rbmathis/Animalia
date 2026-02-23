namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neacomys;

/// <summary>
/// Species: Neacomys rosalindae
/// NCBI TaxId: 2844897
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neacomys_rosalindae : Neacomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neacomys rosalindae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neacomys_rosalindae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2844897;
}
