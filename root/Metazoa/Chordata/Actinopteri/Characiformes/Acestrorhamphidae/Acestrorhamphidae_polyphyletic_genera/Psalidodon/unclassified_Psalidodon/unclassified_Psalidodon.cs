using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Acestrorhamphidae_polyphyletic_genera.Psalidodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Acestrorhamphidae_polyphyletic_genera.Psalidodon.unclassified_Psalidodon;

/// <summary>
/// Abstract class for unclassified Psalidodon (no rank).
/// NCBI TaxId: 3378510
/// </summary>
public abstract class unclassified_Psalidodon : Psalidodon, Iunclassified_Psalidodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psalidodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3378510;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psalidodon";
}
