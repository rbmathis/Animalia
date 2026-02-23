using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Vinciguerria;

/// <summary>
/// Abstract class for Vinciguerria (genus).
/// NCBI TaxId: 258047
/// </summary>
public abstract class Vinciguerria : Phosichthyidae, IVinciguerria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vinciguerria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 258047;

    /// <inheritdoc />
    public virtual string GenusName => "Vinciguerria";

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
