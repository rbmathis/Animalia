using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Deltamys;

/// <summary>
/// Abstract class for Deltamys (genus).
/// NCBI TaxId: 230083
/// </summary>
public abstract class Deltamys : Cricetidae, IDeltamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deltamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 230083;

    /// <inheritdoc />
    public virtual string GenusName => "Deltamys";

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
