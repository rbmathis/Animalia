namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis montivagus
/// NCBI TaxId: 159329
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_montivagus : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis montivagus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_montivagus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 159329;
}
