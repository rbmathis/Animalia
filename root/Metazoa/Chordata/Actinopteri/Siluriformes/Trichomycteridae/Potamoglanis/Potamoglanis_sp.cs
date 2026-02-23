namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Potamoglanis;

/// <summary>
/// Species: Potamoglanis sp.
/// NCBI TaxId: 3082542
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Potamoglanis_sp : Potamoglanis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Potamoglanis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Potamoglanis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3082542;
}
