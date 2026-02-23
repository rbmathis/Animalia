using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Nyctophilopython;

/// <summary>
/// Abstract class for Nyctophilopython (genus).
/// NCBI TaxId: 3148892
/// </summary>
public abstract class Nyctophilopython : Pythonidae, INyctophilopython
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctophilopython";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148892;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctophilopython";

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
