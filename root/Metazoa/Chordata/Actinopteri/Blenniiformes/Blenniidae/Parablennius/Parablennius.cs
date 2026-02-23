using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Parablennius;

/// <summary>
/// Abstract class for Parablennius (genus).
/// NCBI TaxId: 57842
/// </summary>
public abstract class Parablennius : Blenniidae, IParablennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parablennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57842;

    /// <inheritdoc />
    public virtual string GenusName => "Parablennius";

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
