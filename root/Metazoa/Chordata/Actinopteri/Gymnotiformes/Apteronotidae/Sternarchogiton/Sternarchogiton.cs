using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchogiton;

/// <summary>
/// Abstract class for Sternarchogiton (genus).
/// NCBI TaxId: 36677
/// </summary>
public abstract class Sternarchogiton : Apteronotidae, ISternarchogiton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sternarchogiton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36677;

    /// <inheritdoc />
    public virtual string GenusName => "Sternarchogiton";

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
