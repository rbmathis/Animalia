using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Sphaerichthys;

/// <summary>
/// Abstract class for Sphaerichthys (genus).
/// NCBI TaxId: 313233
/// </summary>
public abstract class Sphaerichthys : Osphronemidae, ISphaerichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphaerichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 313233;

    /// <inheritdoc />
    public virtual string GenusName => "Sphaerichthys";

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
