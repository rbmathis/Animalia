using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Desmodillus;

/// <summary>
/// Abstract class for Desmodillus (genus).
/// NCBI TaxId: 298895
/// </summary>
public abstract class Desmodillus : Muridae, IDesmodillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Desmodillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 298895;

    /// <inheritdoc />
    public virtual string GenusName => "Desmodillus";

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
