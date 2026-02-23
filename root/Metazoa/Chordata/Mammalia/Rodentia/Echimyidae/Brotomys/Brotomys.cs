using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Brotomys;

/// <summary>
/// Abstract class for Brotomys (genus).
/// NCBI TaxId: 2779809
/// </summary>
public abstract class Brotomys : Echimyidae, IBrotomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brotomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2779809;

    /// <inheritdoc />
    public virtual string GenusName => "Brotomys";

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
