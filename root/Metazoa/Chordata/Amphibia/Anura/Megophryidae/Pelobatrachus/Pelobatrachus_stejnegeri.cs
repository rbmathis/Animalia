namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Pelobatrachus;

/// <summary>
/// Species: Pelobatrachus stejnegeri
/// NCBI TaxId: 1903876
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelobatrachus_stejnegeri : Pelobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelobatrachus stejnegeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelobatrachus_stejnegeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1903876;
}
