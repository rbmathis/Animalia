using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Urotrichus;

/// <summary>
/// Abstract class for Urotrichus (genus).
/// NCBI TaxId: 106105
/// </summary>
public abstract class Urotrichus : Talpidae, IUrotrichus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urotrichus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 106105;

    /// <inheritdoc />
    public virtual string GenusName => "Urotrichus";

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
