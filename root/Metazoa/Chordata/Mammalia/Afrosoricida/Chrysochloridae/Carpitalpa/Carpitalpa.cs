using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Carpitalpa;

/// <summary>
/// Abstract class for Carpitalpa (genus).
/// NCBI TaxId: 745244
/// </summary>
public abstract class Carpitalpa : Chrysochloridae, ICarpitalpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carpitalpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745244;

    /// <inheritdoc />
    public virtual string GenusName => "Carpitalpa";

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
