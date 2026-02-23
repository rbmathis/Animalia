using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Signigobius;

/// <summary>
/// Abstract class for Signigobius (genus).
/// NCBI TaxId: 622428
/// </summary>
public abstract class Signigobius : Gobiidae, ISignigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Signigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 622428;

    /// <inheritdoc />
    public virtual string GenusName => "Signigobius";

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
