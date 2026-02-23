namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Sterna;

/// <summary>
/// Species: Sterna hirundo
/// NCBI TaxId: 108405
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sterna_hirundo : Sterna
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sterna hirundo";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sterna_hirundo";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 108405;
}
