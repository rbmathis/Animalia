namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Iguanodectes;

/// <summary>
/// Species: Iguanodectes sp.
/// NCBI TaxId: 3451282
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Iguanodectes_sp : Iguanodectes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Iguanodectes sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Iguanodectes_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3451282;
}
