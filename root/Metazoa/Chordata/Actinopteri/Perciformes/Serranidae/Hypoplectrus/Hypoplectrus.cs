using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Hypoplectrus;

/// <summary>
/// Abstract class for Hypoplectrus (genus).
/// NCBI TaxId: 146807
/// </summary>
public abstract class Hypoplectrus : Serranidae, IHypoplectrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypoplectrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 146807;

    /// <inheritdoc />
    public virtual string GenusName => "Hypoplectrus";

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
