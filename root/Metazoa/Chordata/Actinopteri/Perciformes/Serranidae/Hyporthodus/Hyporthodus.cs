using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Hyporthodus;

/// <summary>
/// Abstract class for Hyporthodus (genus).
/// NCBI TaxId: 1208316
/// </summary>
public abstract class Hyporthodus : Serranidae, IHyporthodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyporthodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1208316;

    /// <inheritdoc />
    public virtual string GenusName => "Hyporthodus";

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
