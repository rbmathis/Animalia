using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Cratogeomys;

/// <summary>
/// Abstract class for Cratogeomys (genus).
/// NCBI TaxId: 13627
/// </summary>
public abstract class Cratogeomys : Geomyidae, ICratogeomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cratogeomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13627;

    /// <inheritdoc />
    public virtual string GenusName => "Cratogeomys";

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
