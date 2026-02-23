namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Cacatua;

/// <summary>
/// Species: Cacatua sp. CCJ-2008
/// NCBI TaxId: 585476
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacatua_sp_CCJ_2008 : Cacatua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacatua sp. CCJ-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacatua_sp_CCJ_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 585476;
}
