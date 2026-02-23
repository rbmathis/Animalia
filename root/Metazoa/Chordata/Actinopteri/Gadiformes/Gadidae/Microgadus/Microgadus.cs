using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Microgadus;

/// <summary>
/// Abstract class for Microgadus (genus).
/// NCBI TaxId: 34822
/// </summary>
public abstract class Microgadus : Gadidae, IMicrogadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microgadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34822;

    /// <inheritdoc />
    public virtual string GenusName => "Microgadus";

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
