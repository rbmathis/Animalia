using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Suttonia;

/// <summary>
/// Abstract class for Suttonia (genus).
/// NCBI TaxId: 327823
/// </summary>
public abstract class Suttonia : Serranidae, ISuttonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Suttonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327823;

    /// <inheritdoc />
    public virtual string GenusName => "Suttonia";

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
