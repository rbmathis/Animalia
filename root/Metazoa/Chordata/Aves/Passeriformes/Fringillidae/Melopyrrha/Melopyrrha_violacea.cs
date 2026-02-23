namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Melopyrrha;

/// <summary>
/// Species: Melopyrrha violacea
/// NCBI TaxId: 3150140
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Melopyrrha_violacea : Melopyrrha
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Melopyrrha violacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Melopyrrha_violacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150140;
}
