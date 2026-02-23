using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Nesogale;

/// <summary>
/// Abstract class for Nesogale (genus).
/// NCBI TaxId: 2583310
/// </summary>
public abstract class Nesogale : Tenrecidae, INesogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2583310;

    /// <inheritdoc />
    public virtual string GenusName => "Nesogale";

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
