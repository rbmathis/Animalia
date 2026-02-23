using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Rosenblattichthys;

/// <summary>
/// Abstract class for Rosenblattichthys (genus).
/// NCBI TaxId: 1622140
/// </summary>
public abstract class Rosenblattichthys : Scopelarchidae, IRosenblattichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rosenblattichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1622140;

    /// <inheritdoc />
    public virtual string GenusName => "Rosenblattichthys";

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
