namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus altipinnis
/// NCBI TaxId: 1604521
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_altipinnis : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus altipinnis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_altipinnis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1604521;
}
