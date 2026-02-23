using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Hemicentetes;

/// <summary>
/// Abstract class for Hemicentetes (genus).
/// NCBI TaxId: 319812
/// </summary>
public abstract class Hemicentetes : Tenrecidae, IHemicentetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemicentetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319812;

    /// <inheritdoc />
    public virtual string GenusName => "Hemicentetes";

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
