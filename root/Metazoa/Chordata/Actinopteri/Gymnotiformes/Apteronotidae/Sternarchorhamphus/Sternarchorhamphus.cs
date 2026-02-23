using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchorhamphus;

/// <summary>
/// Abstract class for Sternarchorhamphus (genus).
/// NCBI TaxId: 36679
/// </summary>
public abstract class Sternarchorhamphus : Apteronotidae, ISternarchorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sternarchorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36679;

    /// <inheritdoc />
    public virtual string GenusName => "Sternarchorhamphus";

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
