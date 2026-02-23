using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Philoria;

/// <summary>
/// Abstract class for Philoria (genus).
/// NCBI TaxId: 218470
/// </summary>
public abstract class Philoria : Limnodynastidae, IPhiloria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philoria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 218470;

    /// <inheritdoc />
    public virtual string GenusName => "Philoria";

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
