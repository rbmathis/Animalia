namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Muscigralla;

/// <summary>
/// Species: Muscigralla brevicauda
/// NCBI TaxId: 123645
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muscigralla_brevicauda : Muscigralla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muscigralla brevicauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muscigralla_brevicauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 123645;
}
