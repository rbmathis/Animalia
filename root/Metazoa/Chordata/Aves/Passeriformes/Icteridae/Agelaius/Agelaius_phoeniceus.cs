namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Agelaius;

/// <summary>
/// Species: Agelaius phoeniceus
/// NCBI TaxId: 39638
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agelaius_phoeniceus : Agelaius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agelaius phoeniceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agelaius_phoeniceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39638;
}
