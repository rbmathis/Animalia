using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Bathylagoides;

/// <summary>
/// Abstract class for Bathylagoides (genus).
/// NCBI TaxId: 182446
/// </summary>
public abstract class Bathylagoides : Bathylagidae, IBathylagoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathylagoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182446;

    /// <inheritdoc />
    public virtual string GenusName => "Bathylagoides";

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
