using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Toenayar;

/// <summary>
/// Abstract class for Toenayar (genus).
/// NCBI TaxId: 2230937
/// </summary>
public abstract class Toenayar : Scincidae, IToenayar
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Toenayar";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2230937;

    /// <inheritdoc />
    public virtual string GenusName => "Toenayar";

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
