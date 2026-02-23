using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Cryptochloris;

/// <summary>
/// Abstract class for Cryptochloris (genus).
/// NCBI TaxId: 745251
/// </summary>
public abstract class Cryptochloris : Chrysochloridae, ICryptochloris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptochloris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745251;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptochloris";

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
