using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Gonioplectrus;

/// <summary>
/// Abstract class for Gonioplectrus (genus).
/// NCBI TaxId: 1550406
/// </summary>
public abstract class Gonioplectrus : Serranidae, IGonioplectrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gonioplectrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1550406;

    /// <inheritdoc />
    public virtual string GenusName => "Gonioplectrus";

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
