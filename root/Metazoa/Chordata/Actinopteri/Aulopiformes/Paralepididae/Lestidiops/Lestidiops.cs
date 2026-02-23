using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Lestidiops;

/// <summary>
/// Abstract class for Lestidiops (genus).
/// NCBI TaxId: 319758
/// </summary>
public abstract class Lestidiops : Paralepididae, ILestidiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lestidiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319758;

    /// <inheritdoc />
    public virtual string GenusName => "Lestidiops";

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
