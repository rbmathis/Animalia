using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Lagorchestes;

/// <summary>
/// Abstract class for Lagorchestes (genus).
/// NCBI TaxId: 65623
/// </summary>
public abstract class Lagorchestes : Macropodidae, ILagorchestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagorchestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 65623;

    /// <inheritdoc />
    public virtual string GenusName => "Lagorchestes";

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
