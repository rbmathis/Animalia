using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Aphyocheirodon;

/// <summary>
/// Abstract class for Aphyocheirodon (genus).
/// NCBI TaxId: 303975
/// </summary>
public abstract class Aphyocheirodon : Characidae, IAphyocheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphyocheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303975;

    /// <inheritdoc />
    public virtual string GenusName => "Aphyocheirodon";

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
