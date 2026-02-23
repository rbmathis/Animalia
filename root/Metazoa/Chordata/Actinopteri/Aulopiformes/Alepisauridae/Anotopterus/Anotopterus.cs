using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Alepisauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Alepisauridae.Anotopterus;

/// <summary>
/// Abstract class for Anotopterus (genus).
/// NCBI TaxId: 172141
/// </summary>
public abstract class Anotopterus : Alepisauridae, IAnotopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anotopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172141;

    /// <inheritdoc />
    public virtual string GenusName => "Anotopterus";

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
