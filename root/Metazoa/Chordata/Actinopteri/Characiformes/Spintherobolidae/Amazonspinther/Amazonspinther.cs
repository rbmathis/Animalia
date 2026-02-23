using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Spintherobolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Spintherobolidae.Amazonspinther;

/// <summary>
/// Abstract class for Amazonspinther (genus).
/// NCBI TaxId: 1315334
/// </summary>
public abstract class Amazonspinther : Spintherobolidae, IAmazonspinther
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amazonspinther";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1315334;

    /// <inheritdoc />
    public virtual string GenusName => "Amazonspinther";

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
