using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Hippoglossus;

/// <summary>
/// Abstract class for Hippoglossus (genus).
/// NCBI TaxId: 8266
/// </summary>
public abstract class Hippoglossus : Pleuronectidae, IHippoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hippoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8266;

    /// <inheritdoc />
    public virtual string GenusName => "Hippoglossus";

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
