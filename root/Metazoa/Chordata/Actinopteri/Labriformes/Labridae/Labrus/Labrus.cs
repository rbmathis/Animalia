using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Labrus;

/// <summary>
/// Abstract class for Labrus (genus).
/// NCBI TaxId: 30799
/// </summary>
public abstract class Labrus : Labridae, ILabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30799;

    /// <inheritdoc />
    public virtual string GenusName => "Labrus";

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
