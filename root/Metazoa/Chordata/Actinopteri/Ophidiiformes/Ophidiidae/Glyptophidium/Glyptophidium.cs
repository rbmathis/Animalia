using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Glyptophidium;

/// <summary>
/// Abstract class for Glyptophidium (genus).
/// NCBI TaxId: 1414494
/// </summary>
public abstract class Glyptophidium : Ophidiidae, IGlyptophidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyptophidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1414494;

    /// <inheritdoc />
    public virtual string GenusName => "Glyptophidium";

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
