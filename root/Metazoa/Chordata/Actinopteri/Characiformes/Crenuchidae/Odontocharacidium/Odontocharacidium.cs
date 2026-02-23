using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Odontocharacidium;

/// <summary>
/// Abstract class for Odontocharacidium (genus).
/// NCBI TaxId: 2812819
/// </summary>
public abstract class Odontocharacidium : Crenuchidae, IOdontocharacidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontocharacidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2812819;

    /// <inheritdoc />
    public virtual string GenusName => "Odontocharacidium";

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
