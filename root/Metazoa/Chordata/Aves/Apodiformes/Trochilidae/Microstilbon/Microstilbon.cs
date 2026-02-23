using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Microstilbon;

/// <summary>
/// Abstract class for Microstilbon (genus).
/// NCBI TaxId: 689228
/// </summary>
public abstract class Microstilbon : Trochilidae, IMicrostilbon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microstilbon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689228;

    /// <inheritdoc />
    public virtual string GenusName => "Microstilbon";

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
