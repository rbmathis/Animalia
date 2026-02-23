using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Microstomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Microstomatidae.Microstoma;

/// <summary>
/// Abstract class for Microstoma (genus).
/// NCBI TaxId: 210570
/// </summary>
public abstract class Microstoma : Microstomatidae, IMicrostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microstoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210570;

    /// <inheritdoc />
    public virtual string GenusName => "Microstoma";

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
