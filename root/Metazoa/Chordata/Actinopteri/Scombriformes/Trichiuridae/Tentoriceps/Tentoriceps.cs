using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Tentoriceps;

/// <summary>
/// Abstract class for Tentoriceps (genus).
/// NCBI TaxId: 1183398
/// </summary>
public abstract class Tentoriceps : Trichiuridae, ITentoriceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tentoriceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1183398;

    /// <inheritdoc />
    public virtual string GenusName => "Tentoriceps";

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
