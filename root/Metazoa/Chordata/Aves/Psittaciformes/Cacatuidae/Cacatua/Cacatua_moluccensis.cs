namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Cacatua;

/// <summary>
/// Species: Cacatua moluccensis
/// NCBI TaxId: 136504
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacatua_moluccensis : Cacatua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacatua moluccensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacatua_moluccensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 136504;
}
