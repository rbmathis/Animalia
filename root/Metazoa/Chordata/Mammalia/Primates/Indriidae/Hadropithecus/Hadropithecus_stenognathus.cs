namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Hadropithecus;

/// <summary>
/// Species: Hadropithecus stenognathus
/// NCBI TaxId: 523825
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hadropithecus_stenognathus : Hadropithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hadropithecus stenognathus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hadropithecus_stenognathus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 523825;
}
