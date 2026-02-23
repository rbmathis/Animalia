using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchella;

/// <summary>
/// Abstract class for Sternarchella (genus).
/// NCBI TaxId: 36675
/// </summary>
public abstract class Sternarchella : Apteronotidae, ISternarchella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sternarchella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36675;

    /// <inheritdoc />
    public virtual string GenusName => "Sternarchella";

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
