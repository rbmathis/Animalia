using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neofiber;

/// <summary>
/// Abstract class for Neofiber (genus).
/// NCBI TaxId: 484904
/// </summary>
public abstract class Neofiber : Cricetidae, INeofiber
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neofiber";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 484904;

    /// <inheritdoc />
    public virtual string GenusName => "Neofiber";

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
