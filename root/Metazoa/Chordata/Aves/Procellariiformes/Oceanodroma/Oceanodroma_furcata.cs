namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanodroma;

/// <summary>
/// Species: Oceanodroma furcata
/// NCBI TaxId: 79631
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oceanodroma_furcata : Oceanodroma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oceanodroma furcata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oceanodroma_furcata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79631;
}
