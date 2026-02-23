using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Genyagnus;

/// <summary>
/// Abstract class for Genyagnus (genus).
/// NCBI TaxId: 2696656
/// </summary>
public abstract class Genyagnus : Uranoscopidae, IGenyagnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Genyagnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696656;

    /// <inheritdoc />
    public virtual string GenusName => "Genyagnus";

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
