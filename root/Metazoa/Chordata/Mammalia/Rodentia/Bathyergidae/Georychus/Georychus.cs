using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Georychus;

/// <summary>
/// Abstract class for Georychus (genus).
/// NCBI TaxId: 10176
/// </summary>
public abstract class Georychus : Bathyergidae, IGeorychus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Georychus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10176;

    /// <inheritdoc />
    public virtual string GenusName => "Georychus";

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
