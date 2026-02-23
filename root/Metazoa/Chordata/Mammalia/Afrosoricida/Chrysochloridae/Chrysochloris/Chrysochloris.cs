using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Chrysochloris;

/// <summary>
/// Abstract class for Chrysochloris (genus).
/// NCBI TaxId: 185452
/// </summary>
public abstract class Chrysochloris : Chrysochloridae, IChrysochloris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysochloris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 185452;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysochloris";

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
