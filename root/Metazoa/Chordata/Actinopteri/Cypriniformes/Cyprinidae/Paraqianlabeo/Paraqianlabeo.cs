using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Paraqianlabeo;

/// <summary>
/// Abstract class for Paraqianlabeo (genus).
/// NCBI TaxId: 1530206
/// </summary>
public abstract class Paraqianlabeo : Cyprinidae, IParaqianlabeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraqianlabeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1530206;

    /// <inheritdoc />
    public virtual string GenusName => "Paraqianlabeo";

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
