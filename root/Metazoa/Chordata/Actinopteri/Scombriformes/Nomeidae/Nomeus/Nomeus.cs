using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Nomeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Nomeidae.Nomeus;

/// <summary>
/// Abstract class for Nomeus (genus).
/// NCBI TaxId: 1003967
/// </summary>
public abstract class Nomeus : Nomeidae, INomeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nomeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003967;

    /// <inheritdoc />
    public virtual string GenusName => "Nomeus";

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
