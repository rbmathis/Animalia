using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Parascalops;

/// <summary>
/// Abstract class for Parascalops (genus).
/// NCBI TaxId: 94436
/// </summary>
public abstract class Parascalops : Talpidae, IParascalops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parascalops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94436;

    /// <inheritdoc />
    public virtual string GenusName => "Parascalops";

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
