namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycephala;

/// <summary>
/// Species: Pachycephala melanura
/// NCBI TaxId: 381036
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachycephala_melanura : Pachycephala
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachycephala melanura";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachycephala_melanura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 381036;
}
