using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Mylodon;

/// <summary>
/// Abstract class for Mylodon (genus).
/// NCBI TaxId: 48783
/// </summary>
public abstract class Mylodon : Mylodontidae, IMylodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mylodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48783;

    /// <inheritdoc />
    public virtual string GenusName => "Mylodon";

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
