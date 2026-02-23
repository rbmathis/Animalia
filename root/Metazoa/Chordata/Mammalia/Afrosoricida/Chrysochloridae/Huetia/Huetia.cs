using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Huetia;

/// <summary>
/// Abstract class for Huetia (genus).
/// NCBI TaxId: 746122
/// </summary>
public abstract class Huetia : Chrysochloridae, IHuetia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Huetia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 746122;

    /// <inheritdoc />
    public virtual string GenusName => "Huetia";

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
