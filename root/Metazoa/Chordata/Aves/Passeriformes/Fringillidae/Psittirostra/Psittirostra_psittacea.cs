namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Psittirostra;

/// <summary>
/// Species: Psittirostra psittacea
/// NCBI TaxId: 1804742
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittirostra_psittacea : Psittirostra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittirostra psittacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittirostra_psittacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1804742;
}
