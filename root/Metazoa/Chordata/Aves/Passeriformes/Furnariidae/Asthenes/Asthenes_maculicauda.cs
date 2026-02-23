namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Asthenes;

/// <summary>
/// Species: Asthenes maculicauda
/// NCBI TaxId: 1094240
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Asthenes_maculicauda : Asthenes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Asthenes maculicauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Asthenes_maculicauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1094240;
}
