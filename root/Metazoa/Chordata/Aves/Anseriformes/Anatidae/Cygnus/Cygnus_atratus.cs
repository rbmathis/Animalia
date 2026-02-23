namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cygnus;

/// <summary>
/// Species: Cygnus atratus
/// NCBI TaxId: 8868
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cygnus_atratus : Cygnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cygnus atratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cygnus_atratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8868;
}
