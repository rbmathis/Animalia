using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Trachinocephalus;

/// <summary>
/// Abstract class for Trachinocephalus (genus).
/// NCBI TaxId: 172130
/// </summary>
public abstract class Trachinocephalus : Synodontidae, ITrachinocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachinocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172130;

    /// <inheritdoc />
    public virtual string GenusName => "Trachinocephalus";

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
