using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Channidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Channidae.Channa;

/// <summary>
/// Abstract class for Channa (genus).
/// NCBI TaxId: 33789
/// </summary>
public abstract class Channa : Channidae, IChanna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Channa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33789;

    /// <inheritdoc />
    public virtual string GenusName => "Channa";

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
