namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycephala;

/// <summary>
/// Species: Pachycephala leucogastra
/// NCBI TaxId: 449382
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachycephala_leucogastra : Pachycephala
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachycephala leucogastra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachycephala_leucogastra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 449382;
}
