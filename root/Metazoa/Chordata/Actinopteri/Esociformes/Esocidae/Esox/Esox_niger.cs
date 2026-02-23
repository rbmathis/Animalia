namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Esocidae.Esox;

/// <summary>
/// Species: Esox niger
/// NCBI TaxId: 184451
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Esox_niger : Esox
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Esox niger";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Esox_niger";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 184451;
}
