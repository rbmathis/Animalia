namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calomys;

/// <summary>
/// Species: Calomys fecundus
/// NCBI TaxId: 160455
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calomys_fecundus : Calomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calomys fecundus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calomys_fecundus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 160455;
}
