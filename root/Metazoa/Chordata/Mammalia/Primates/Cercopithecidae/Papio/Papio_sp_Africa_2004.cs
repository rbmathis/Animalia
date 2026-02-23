namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Papio;

/// <summary>
/// Species: Papio sp. Africa-2004
/// NCBI TaxId: 285280
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Papio_sp_Africa_2004 : Papio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Papio sp. Africa-2004";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Papio_sp_Africa_2004";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 285280;
}
