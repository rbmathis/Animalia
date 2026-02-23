using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Gymnotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Gymnotidae.Gymnotus;

/// <summary>
/// Abstract class for Gymnotus (genus).
/// NCBI TaxId: 36670
/// </summary>
public abstract class Gymnotus : Gymnotidae, IGymnotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36670;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnotus";

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
