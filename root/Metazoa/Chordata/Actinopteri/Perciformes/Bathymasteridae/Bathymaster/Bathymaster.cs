using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathymasteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathymasteridae.Bathymaster;

/// <summary>
/// Abstract class for Bathymaster (genus).
/// NCBI TaxId: 274807
/// </summary>
public abstract class Bathymaster : Bathymasteridae, IBathymaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathymaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274807;

    /// <inheritdoc />
    public virtual string GenusName => "Bathymaster";

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
