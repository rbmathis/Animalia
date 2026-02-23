namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Dendromus;

/// <summary>
/// Species: Dendromus cf. melanotis
/// NCBI TaxId: 1890058
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendromus_cf_melanotis : Dendromus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendromus cf. melanotis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendromus_cf_melanotis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1890058;
}
