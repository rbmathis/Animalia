using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Thyriscus;

/// <summary>
/// Abstract class for Thyriscus (genus).
/// NCBI TaxId: 3362288
/// </summary>
public abstract class Thyriscus : Cottidae, IThyriscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thyriscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362288;

    /// <inheritdoc />
    public virtual string GenusName => "Thyriscus";

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
