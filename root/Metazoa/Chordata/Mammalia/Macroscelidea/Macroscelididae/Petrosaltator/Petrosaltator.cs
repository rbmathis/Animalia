using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Petrosaltator;

/// <summary>
/// Abstract class for Petrosaltator (genus).
/// NCBI TaxId: 1873009
/// </summary>
public abstract class Petrosaltator : Macroscelididae, IPetrosaltator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petrosaltator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1873009;

    /// <inheritdoc />
    public virtual string GenusName => "Petrosaltator";

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
