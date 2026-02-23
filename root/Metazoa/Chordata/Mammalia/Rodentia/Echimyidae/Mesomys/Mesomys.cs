using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Mesomys;

/// <summary>
/// Abstract class for Mesomys (genus).
/// NCBI TaxId: 30626
/// </summary>
public abstract class Mesomys : Echimyidae, IMesomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30626;

    /// <inheritdoc />
    public virtual string GenusName => "Mesomys";

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
