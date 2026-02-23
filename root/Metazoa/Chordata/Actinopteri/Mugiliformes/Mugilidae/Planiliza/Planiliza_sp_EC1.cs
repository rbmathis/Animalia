namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Planiliza;

/// <summary>
/// Species: Planiliza sp. EC1
/// NCBI TaxId: 3020381
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Planiliza_sp_EC1 : Planiliza
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Planiliza sp. EC1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Planiliza_sp_EC1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3020381;
}
