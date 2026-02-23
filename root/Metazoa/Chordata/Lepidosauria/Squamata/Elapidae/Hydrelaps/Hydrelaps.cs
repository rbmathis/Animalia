using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Hydrelaps;

/// <summary>
/// Abstract class for Hydrelaps (genus).
/// NCBI TaxId: 355875
/// </summary>
public abstract class Hydrelaps : Elapidae, IHydrelaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrelaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 355875;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrelaps";

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
