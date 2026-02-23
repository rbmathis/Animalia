using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dasymys;

/// <summary>
/// Abstract class for Dasymys (genus).
/// NCBI TaxId: 71172
/// </summary>
public abstract class Dasymys : Muridae, IDasymys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasymys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71172;

    /// <inheritdoc />
    public virtual string GenusName => "Dasymys";

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
