using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Symphodus;

/// <summary>
/// Abstract class for Symphodus (genus).
/// NCBI TaxId: 130471
/// </summary>
public abstract class Symphodus : Labridae, ISymphodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Symphodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 130471;

    /// <inheritdoc />
    public virtual string GenusName => "Symphodus";

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
