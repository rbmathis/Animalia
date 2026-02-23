using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Solenodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Solenodontidae.Solenodon;

/// <summary>
/// Abstract class for Solenodon (genus).
/// NCBI TaxId: 79804
/// </summary>
public abstract class Solenodon : Solenodontidae, ISolenodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Solenodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 79804;

    /// <inheritdoc />
    public virtual string GenusName => "Solenodon";

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
