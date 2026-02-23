namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Cacatua;

/// <summary>
/// Species: Cacatua sanguinea
/// NCBI TaxId: 274074
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacatua_sanguinea : Cacatua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacatua sanguinea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacatua_sanguinea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 274074;
}
