namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus hemipinnis
/// NCBI TaxId: 436872
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_hemipinnis : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus hemipinnis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_hemipinnis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 436872;
}
