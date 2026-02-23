using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Belontia;

/// <summary>
/// Abstract class for Belontia (genus).
/// NCBI TaxId: 313175
/// </summary>
public abstract class Belontia : Osphronemidae, IBelontia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belontia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 313175;

    /// <inheritdoc />
    public virtual string GenusName => "Belontia";

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
