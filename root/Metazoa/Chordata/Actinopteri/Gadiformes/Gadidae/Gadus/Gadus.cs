using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Gadus;

/// <summary>
/// Abstract class for Gadus (genus).
/// NCBI TaxId: 8048
/// </summary>
public abstract class Gadus : Gadidae, IGadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8048;

    /// <inheritdoc />
    public virtual string GenusName => "Gadus";

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
