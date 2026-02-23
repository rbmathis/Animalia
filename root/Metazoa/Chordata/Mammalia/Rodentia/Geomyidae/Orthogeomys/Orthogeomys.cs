using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Orthogeomys;

/// <summary>
/// Abstract class for Orthogeomys (genus).
/// NCBI TaxId: 35661
/// </summary>
public abstract class Orthogeomys : Geomyidae, IOrthogeomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthogeomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 35661;

    /// <inheritdoc />
    public virtual string GenusName => "Orthogeomys";

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
