namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Bartramia;

/// <summary>
/// Species: Bartramia longicauda
/// NCBI TaxId: 279933
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bartramia_longicauda : Bartramia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bartramia longicauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bartramia_longicauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279933;
}
