namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Esocidae.Esox;

/// <summary>
/// Species: Esox lucius
/// NCBI TaxId: 8010
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Esox_lucius : Esox
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Esox lucius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Esox_lucius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8010;
}
