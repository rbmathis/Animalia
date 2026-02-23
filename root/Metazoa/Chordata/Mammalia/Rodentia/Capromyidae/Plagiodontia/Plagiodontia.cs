using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae.Plagiodontia;

/// <summary>
/// Abstract class for Plagiodontia (genus).
/// NCBI TaxId: 1163664
/// </summary>
public abstract class Plagiodontia : Capromyidae, IPlagiodontia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plagiodontia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1163664;

    /// <inheritdoc />
    public virtual string GenusName => "Plagiodontia";

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
