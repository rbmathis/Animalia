using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Geomys;

/// <summary>
/// Abstract class for Geomys (genus).
/// NCBI TaxId: 13544
/// </summary>
public abstract class Geomys : Geomyidae, IGeomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13544;

    /// <inheritdoc />
    public virtual string GenusName => "Geomys";

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
