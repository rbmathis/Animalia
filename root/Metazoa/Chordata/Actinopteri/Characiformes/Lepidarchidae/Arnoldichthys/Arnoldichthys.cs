using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lepidarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lepidarchidae.Arnoldichthys;

/// <summary>
/// Abstract class for Arnoldichthys (genus).
/// NCBI TaxId: 303977
/// </summary>
public abstract class Arnoldichthys : Lepidarchidae, IArnoldichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arnoldichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303977;

    /// <inheritdoc />
    public virtual string GenusName => "Arnoldichthys";

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
