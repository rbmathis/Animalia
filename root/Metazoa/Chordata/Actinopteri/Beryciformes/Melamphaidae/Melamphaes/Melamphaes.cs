using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Melamphaes;

/// <summary>
/// Abstract class for Melamphaes (genus).
/// NCBI TaxId: 319443
/// </summary>
public abstract class Melamphaes : Melamphaidae, IMelamphaes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melamphaes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319443;

    /// <inheritdoc />
    public virtual string GenusName => "Melamphaes";

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
