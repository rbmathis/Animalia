using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae.Mesocapromys;

/// <summary>
/// Abstract class for Mesocapromys (genus).
/// NCBI TaxId: 1567508
/// </summary>
public abstract class Mesocapromys : Capromyidae, IMesocapromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesocapromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1567508;

    /// <inheritdoc />
    public virtual string GenusName => "Mesocapromys";

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
