using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lophuromys;

/// <summary>
/// Abstract class for Lophuromys (genus).
/// NCBI TaxId: 51347
/// </summary>
public abstract class Lophuromys : Muridae, ILophuromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophuromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51347;

    /// <inheritdoc />
    public virtual string GenusName => "Lophuromys";

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
