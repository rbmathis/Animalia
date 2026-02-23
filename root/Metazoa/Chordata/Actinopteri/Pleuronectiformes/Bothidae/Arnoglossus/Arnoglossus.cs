using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Arnoglossus;

/// <summary>
/// Abstract class for Arnoglossus (genus).
/// NCBI TaxId: 157240
/// </summary>
public abstract class Arnoglossus : Bothidae, IArnoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arnoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 157240;

    /// <inheritdoc />
    public virtual string GenusName => "Arnoglossus";

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
