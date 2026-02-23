using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Setifer;

/// <summary>
/// Abstract class for Setifer (genus).
/// NCBI TaxId: 319818
/// </summary>
public abstract class Setifer : Tenrecidae, ISetifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Setifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319818;

    /// <inheritdoc />
    public virtual string GenusName => "Setifer";

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
