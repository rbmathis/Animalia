using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Orsinigobius;

/// <summary>
/// Abstract class for Orsinigobius (genus).
/// NCBI TaxId: 1484170
/// </summary>
public abstract class Orsinigobius : Gobiidae, IOrsinigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orsinigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1484170;

    /// <inheritdoc />
    public virtual string GenusName => "Orsinigobius";

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
