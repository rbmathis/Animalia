using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Larsonella;

/// <summary>
/// Abstract class for Larsonella (genus).
/// NCBI TaxId: 2152750
/// </summary>
public abstract class Larsonella : Gobiidae, ILarsonella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Larsonella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2152750;

    /// <inheritdoc />
    public virtual string GenusName => "Larsonella";

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
