using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Lepophidium;

/// <summary>
/// Abstract class for Lepophidium (genus).
/// NCBI TaxId: 334370
/// </summary>
public abstract class Lepophidium : Ophidiidae, ILepophidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepophidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334370;

    /// <inheritdoc />
    public virtual string GenusName => "Lepophidium";

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
