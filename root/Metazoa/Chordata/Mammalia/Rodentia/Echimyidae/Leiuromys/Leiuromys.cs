using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Leiuromys;

/// <summary>
/// Abstract class for Leiuromys (genus).
/// NCBI TaxId: 2171664
/// </summary>
public abstract class Leiuromys : Echimyidae, ILeiuromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiuromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2171664;

    /// <inheritdoc />
    public virtual string GenusName => "Leiuromys";

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
