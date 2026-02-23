using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Assurger;

/// <summary>
/// Abstract class for Assurger (genus).
/// NCBI TaxId: 320585
/// </summary>
public abstract class Assurger : Trichiuridae, IAssurger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Assurger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320585;

    /// <inheritdoc />
    public virtual string GenusName => "Assurger";

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
