using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Parabathymyrus;

/// <summary>
/// Abstract class for Parabathymyrus (genus).
/// NCBI TaxId: 189927
/// </summary>
public abstract class Parabathymyrus : Congridae, IParabathymyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parabathymyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189927;

    /// <inheritdoc />
    public virtual string GenusName => "Parabathymyrus";

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
