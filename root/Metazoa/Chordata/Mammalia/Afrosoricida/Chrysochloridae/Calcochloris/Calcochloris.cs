using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Calcochloris;

/// <summary>
/// Abstract class for Calcochloris (genus).
/// NCBI TaxId: 745242
/// </summary>
public abstract class Calcochloris : Chrysochloridae, ICalcochloris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calcochloris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745242;

    /// <inheritdoc />
    public virtual string GenusName => "Calcochloris";

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
