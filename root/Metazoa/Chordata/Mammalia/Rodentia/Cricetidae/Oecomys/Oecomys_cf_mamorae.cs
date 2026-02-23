namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys cf. mamorae
/// NCBI TaxId: 1868303
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_cf_mamorae : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys cf. mamorae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_cf_mamorae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1868303;
}
