using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Acestrorhamphidae_polyphyletic_genera;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Acestrorhamphidae_polyphyletic_genera.Psalidodon;

/// <summary>
/// Abstract class for Psalidodon (genus).
/// NCBI TaxId: 2729152
/// </summary>
public abstract class Psalidodon : Acestrorhamphidae_polyphyletic_genera, IPsalidodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psalidodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2729152;

    /// <inheritdoc />
    public virtual string GenusName => "Psalidodon";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
