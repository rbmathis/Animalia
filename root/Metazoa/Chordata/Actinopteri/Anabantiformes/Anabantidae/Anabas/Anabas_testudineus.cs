namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Anabas;

/// <summary>
/// Species: Anabas testudineus
/// NCBI TaxId: 64144
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anabas_testudineus : Anabas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anabas testudineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anabas_testudineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 64144;
}
