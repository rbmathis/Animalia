using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Grammatobothus;

/// <summary>
/// Abstract class for Grammatobothus (genus).
/// NCBI TaxId: 1156761
/// </summary>
public abstract class Grammatobothus : Bothidae, IGrammatobothus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammatobothus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156761;

    /// <inheritdoc />
    public virtual string GenusName => "Grammatobothus";

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
