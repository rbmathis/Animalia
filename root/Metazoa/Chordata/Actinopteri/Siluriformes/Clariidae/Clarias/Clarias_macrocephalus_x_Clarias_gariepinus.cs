namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias;

/// <summary>
/// Species: Clarias macrocephalus x Clarias gariepinus
/// NCBI TaxId: 1334085
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clarias_macrocephalus_x_Clarias_gariepinus : Clarias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clarias macrocephalus x Clarias gariepinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clarias_macrocephalus_x_Clarias_gariepinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1334085;
}
