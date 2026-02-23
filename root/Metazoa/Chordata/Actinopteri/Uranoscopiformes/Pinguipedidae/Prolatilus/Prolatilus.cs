using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae.Prolatilus;

/// <summary>
/// Abstract class for Prolatilus (genus).
/// NCBI TaxId: 1572339
/// </summary>
public abstract class Prolatilus : Pinguipedidae, IProlatilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prolatilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1572339;

    /// <inheritdoc />
    public virtual string GenusName => "Prolatilus";

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
