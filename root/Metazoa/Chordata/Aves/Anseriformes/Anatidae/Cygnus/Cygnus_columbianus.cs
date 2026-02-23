namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cygnus;

/// <summary>
/// Species: Cygnus columbianus
/// NCBI TaxId: 110926
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cygnus_columbianus : Cygnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cygnus columbianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cygnus_columbianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 110926;
}
