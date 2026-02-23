using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paraulopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paraulopidae.Paraulopus;

/// <summary>
/// Abstract class for Paraulopus (genus).
/// NCBI TaxId: 509848
/// </summary>
public abstract class Paraulopus : Paraulopidae, IParaulopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraulopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 509848;

    /// <inheritdoc />
    public virtual string GenusName => "Paraulopus";

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
