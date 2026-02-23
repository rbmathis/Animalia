using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Frostius;

/// <summary>
/// Abstract class for Frostius (genus).
/// NCBI TaxId: 1273206
/// </summary>
public abstract class Frostius : Bufonidae, IFrostius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Frostius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1273206;

    /// <inheritdoc />
    public virtual string GenusName => "Frostius";

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
