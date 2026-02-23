using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Bathyanthias;

/// <summary>
/// Abstract class for Bathyanthias (genus).
/// NCBI TaxId: 1501135
/// </summary>
public abstract class Bathyanthias : Serranidae, IBathyanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathyanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1501135;

    /// <inheritdoc />
    public virtual string GenusName => "Bathyanthias";

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
