using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Macropinna;

/// <summary>
/// Abstract class for Macropinna (genus).
/// NCBI TaxId: 557409
/// </summary>
public abstract class Macropinna : Opisthoproctidae, IMacropinna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macropinna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 557409;

    /// <inheritdoc />
    public virtual string GenusName => "Macropinna";

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
