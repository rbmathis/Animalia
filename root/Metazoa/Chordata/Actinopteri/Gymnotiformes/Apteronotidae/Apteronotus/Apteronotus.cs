using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Apteronotus;

/// <summary>
/// Abstract class for Apteronotus (genus).
/// NCBI TaxId: 36672
/// </summary>
public abstract class Apteronotus : Apteronotidae, IApteronotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apteronotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36672;

    /// <inheritdoc />
    public virtual string GenusName => "Apteronotus";

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
