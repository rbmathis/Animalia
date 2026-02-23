using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Zoarchias;

/// <summary>
/// Abstract class for Zoarchias (genus).
/// NCBI TaxId: 1358740
/// </summary>
public abstract class Zoarchias : Zoarcidae, IZoarchias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zoarchias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1358740;

    /// <inheritdoc />
    public virtual string GenusName => "Zoarchias";

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
