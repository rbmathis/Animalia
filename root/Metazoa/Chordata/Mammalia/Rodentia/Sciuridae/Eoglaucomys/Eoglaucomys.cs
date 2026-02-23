using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Eoglaucomys;

/// <summary>
/// Abstract class for Eoglaucomys (genus).
/// NCBI TaxId: 226810
/// </summary>
public abstract class Eoglaucomys : Sciuridae, IEoglaucomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eoglaucomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226810;

    /// <inheritdoc />
    public virtual string GenusName => "Eoglaucomys";

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
