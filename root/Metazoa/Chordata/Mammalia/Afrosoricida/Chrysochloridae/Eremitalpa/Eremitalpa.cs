using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Eremitalpa;

/// <summary>
/// Abstract class for Eremitalpa (genus).
/// NCBI TaxId: 481706
/// </summary>
public abstract class Eremitalpa : Chrysochloridae, IEremitalpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremitalpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 481706;

    /// <inheritdoc />
    public virtual string GenusName => "Eremitalpa";

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
