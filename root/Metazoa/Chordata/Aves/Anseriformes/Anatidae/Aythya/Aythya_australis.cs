namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Aythya;

/// <summary>
/// Species: Aythya australis
/// NCBI TaxId: 45635
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aythya_australis : Aythya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aythya australis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aythya_australis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45635;
}
