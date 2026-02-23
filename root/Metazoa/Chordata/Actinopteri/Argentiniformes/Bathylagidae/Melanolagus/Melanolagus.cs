using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Melanolagus;

/// <summary>
/// Abstract class for Melanolagus (genus).
/// NCBI TaxId: 182443
/// </summary>
public abstract class Melanolagus : Bathylagidae, IMelanolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182443;

    /// <inheritdoc />
    public virtual string GenusName => "Melanolagus";

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
