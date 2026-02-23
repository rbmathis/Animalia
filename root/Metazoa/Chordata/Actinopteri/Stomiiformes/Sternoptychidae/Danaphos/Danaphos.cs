using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Danaphos;

/// <summary>
/// Abstract class for Danaphos (genus).
/// NCBI TaxId: 875786
/// </summary>
public abstract class Danaphos : Sternoptychidae, IDanaphos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Danaphos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 875786;

    /// <inheritdoc />
    public virtual string GenusName => "Danaphos";

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
