namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Cacatua;

/// <summary>
/// Species: Cacatua tenuirostris
/// NCBI TaxId: 1344800
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacatua_tenuirostris : Cacatua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacatua tenuirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacatua_tenuirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1344800;
}
