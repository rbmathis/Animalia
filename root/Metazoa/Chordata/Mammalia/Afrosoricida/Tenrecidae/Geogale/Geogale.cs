using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Geogale;

/// <summary>
/// Abstract class for Geogale (genus).
/// NCBI TaxId: 176116
/// </summary>
public abstract class Geogale : Tenrecidae, IGeogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176116;

    /// <inheritdoc />
    public virtual string GenusName => "Geogale";

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
