using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eutropis;

/// <summary>
/// Abstract class for Eutropis (genus).
/// NCBI TaxId: 217857
/// </summary>
public abstract class Eutropis : Scincidae, IEutropis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eutropis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 217857;

    /// <inheritdoc />
    public virtual string GenusName => "Eutropis";

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
