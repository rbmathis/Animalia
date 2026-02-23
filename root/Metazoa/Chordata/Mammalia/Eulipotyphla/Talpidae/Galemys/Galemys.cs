using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Galemys;

/// <summary>
/// Abstract class for Galemys (genus).
/// NCBI TaxId: 202256
/// </summary>
public abstract class Galemys : Talpidae, IGalemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202256;

    /// <inheritdoc />
    public virtual string GenusName => "Galemys";

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
