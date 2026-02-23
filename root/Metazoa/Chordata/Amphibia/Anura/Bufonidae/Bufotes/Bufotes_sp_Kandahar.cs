namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufotes;

/// <summary>
/// Species: Bufotes sp. Kandahar
/// NCBI TaxId: 2109709
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufotes_sp_Kandahar : Bufotes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufotes sp. Kandahar";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufotes_sp_Kandahar";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2109709;
}
