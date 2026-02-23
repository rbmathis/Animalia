using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gaidropsaridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gaidropsaridae.Enchelyopus;

/// <summary>
/// Abstract class for Enchelyopus (genus).
/// NCBI TaxId: 81639
/// </summary>
public abstract class Enchelyopus : Gaidropsaridae, IEnchelyopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enchelyopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81639;

    /// <inheritdoc />
    public virtual string GenusName => "Enchelyopus";

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
