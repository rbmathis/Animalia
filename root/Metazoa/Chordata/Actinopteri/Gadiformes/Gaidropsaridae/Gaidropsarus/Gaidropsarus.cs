using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gaidropsaridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gaidropsaridae.Gaidropsarus;

/// <summary>
/// Abstract class for Gaidropsarus (genus).
/// NCBI TaxId: 81642
/// </summary>
public abstract class Gaidropsarus : Gaidropsaridae, IGaidropsarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gaidropsarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81642;

    /// <inheritdoc />
    public virtual string GenusName => "Gaidropsarus";

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
