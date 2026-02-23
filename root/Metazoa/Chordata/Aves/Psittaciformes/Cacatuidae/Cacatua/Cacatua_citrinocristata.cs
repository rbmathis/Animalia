namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Cacatua;

/// <summary>
/// Species: Cacatua citrinocristata
/// NCBI TaxId: 3076085
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacatua_citrinocristata : Cacatua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacatua citrinocristata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacatua_citrinocristata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3076085;
}
