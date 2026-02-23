using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Gracila;

/// <summary>
/// Abstract class for Gracila (genus).
/// NCBI TaxId: 327795
/// </summary>
public abstract class Gracila : Serranidae, IGracila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gracila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327795;

    /// <inheritdoc />
    public virtual string GenusName => "Gracila";

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
