namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Sterna;

/// <summary>
/// Species: Sterna hirundinacea
/// NCBI TaxId: 227186
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sterna_hirundinacea : Sterna
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sterna hirundinacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sterna_hirundinacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 227186;
}
