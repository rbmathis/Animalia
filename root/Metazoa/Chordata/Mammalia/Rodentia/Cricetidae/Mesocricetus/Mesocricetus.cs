using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Mesocricetus;

/// <summary>
/// Abstract class for Mesocricetus (genus).
/// NCBI TaxId: 10035
/// </summary>
public abstract class Mesocricetus : Cricetidae, IMesocricetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesocricetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10035;

    /// <inheritdoc />
    public virtual string GenusName => "Mesocricetus";

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
