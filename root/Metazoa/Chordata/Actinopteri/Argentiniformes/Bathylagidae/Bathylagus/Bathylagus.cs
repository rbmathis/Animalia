using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Bathylagus;

/// <summary>
/// Abstract class for Bathylagus (genus).
/// NCBI TaxId: 170192
/// </summary>
public abstract class Bathylagus : Bathylagidae, IBathylagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathylagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170192;

    /// <inheritdoc />
    public virtual string GenusName => "Bathylagus";

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
