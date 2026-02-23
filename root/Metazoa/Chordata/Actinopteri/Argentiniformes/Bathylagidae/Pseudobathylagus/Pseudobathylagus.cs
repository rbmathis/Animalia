using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Pseudobathylagus;

/// <summary>
/// Abstract class for Pseudobathylagus (genus).
/// NCBI TaxId: 182447
/// </summary>
public abstract class Pseudobathylagus : Bathylagidae, IPseudobathylagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobathylagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182447;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobathylagus";

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
