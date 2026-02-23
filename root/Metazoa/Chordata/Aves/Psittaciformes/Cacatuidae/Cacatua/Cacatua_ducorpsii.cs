namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Cacatua;

/// <summary>
/// Species: Cacatua ducorpsii
/// NCBI TaxId: 141834
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacatua_ducorpsii : Cacatua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacatua ducorpsii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacatua_ducorpsii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 141834;
}
