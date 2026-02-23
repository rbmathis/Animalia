using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Dolicholagus;

/// <summary>
/// Abstract class for Dolicholagus (genus).
/// NCBI TaxId: 182444
/// </summary>
public abstract class Dolicholagus : Bathylagidae, IDolicholagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dolicholagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182444;

    /// <inheritdoc />
    public virtual string GenusName => "Dolicholagus";

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
