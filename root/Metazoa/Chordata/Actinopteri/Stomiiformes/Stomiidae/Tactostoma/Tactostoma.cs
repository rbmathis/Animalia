using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Tactostoma;

/// <summary>
/// Abstract class for Tactostoma (genus).
/// NCBI TaxId: 319450
/// </summary>
public abstract class Tactostoma : Stomiidae, ITactostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tactostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319450;

    /// <inheritdoc />
    public virtual string GenusName => "Tactostoma";

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
