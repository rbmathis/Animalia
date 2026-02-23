namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Pleuronectes;

/// <summary>
/// Species: Pleuronectes platessa x Platichthys flesus
/// NCBI TaxId: 2301317
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pleuronectes_platessa_x_Platichthys_flesus : Pleuronectes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pleuronectes platessa x Platichthys flesus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pleuronectes_platessa_x_Platichthys_flesus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2301317;
}
