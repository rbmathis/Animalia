using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Gracililima;

/// <summary>
/// Abstract class for Gracililima (genus).
/// NCBI TaxId: 2259168
/// </summary>
public abstract class Gracililima : Lamprophiidae, IGracililima
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gracililima";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2259168;

    /// <inheritdoc />
    public virtual string GenusName => "Gracililima";

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
