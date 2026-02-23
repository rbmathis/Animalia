namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Indostomidae.Indostomus;

/// <summary>
/// Species: Indostomus paradoxus
/// NCBI TaxId: 181450
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Indostomus_paradoxus : Indostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Indostomus paradoxus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Indostomus_paradoxus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 181450;
}
