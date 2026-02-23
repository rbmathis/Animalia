using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Microgale;

/// <summary>
/// Abstract class for Microgale (genus).
/// NCBI TaxId: 176114
/// </summary>
public abstract class Microgale : Tenrecidae, IMicrogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microgale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176114;

    /// <inheritdoc />
    public virtual string GenusName => "Microgale";

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
