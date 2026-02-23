namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Chrysemys;

/// <summary>
/// Species: Chrysemys dorsalis
/// NCBI TaxId: 573969
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chrysemys_dorsalis : Chrysemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chrysemys dorsalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chrysemys_dorsalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 573969;
}
