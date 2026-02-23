using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Galea;

/// <summary>
/// Abstract class for Galea (genus).
/// NCBI TaxId: 10145
/// </summary>
public abstract class Galea : Caviidae, IGalea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10145;

    /// <inheritdoc />
    public virtual string GenusName => "Galea";

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
