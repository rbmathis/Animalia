namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pongo;

/// <summary>
/// Species: Pongo tapanuliensis
/// NCBI TaxId: 2051901
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pongo_tapanuliensis : Pongo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pongo tapanuliensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pongo_tapanuliensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2051901;
}
