using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Luciocephalus;

/// <summary>
/// Abstract class for Luciocephalus (genus).
/// NCBI TaxId: 271165
/// </summary>
public abstract class Luciocephalus : Osphronemidae, ILuciocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luciocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 271165;

    /// <inheritdoc />
    public virtual string GenusName => "Luciocephalus";

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
