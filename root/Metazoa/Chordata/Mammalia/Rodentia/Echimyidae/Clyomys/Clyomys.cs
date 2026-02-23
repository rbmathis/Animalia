using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Clyomys;

/// <summary>
/// Abstract class for Clyomys (genus).
/// NCBI TaxId: 176497
/// </summary>
public abstract class Clyomys : Echimyidae, IClyomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clyomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176497;

    /// <inheritdoc />
    public virtual string GenusName => "Clyomys";

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
