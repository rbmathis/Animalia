using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zenionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zenionidae.Capromimus;

/// <summary>
/// Abstract class for Capromimus (genus).
/// NCBI TaxId: 1367216
/// </summary>
public abstract class Capromimus : Zenionidae, ICapromimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Capromimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1367216;

    /// <inheritdoc />
    public virtual string GenusName => "Capromimus";

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
