using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Peckoltia;

/// <summary>
/// Abstract class for Peckoltia (genus).
/// NCBI TaxId: 52089
/// </summary>
public abstract class Peckoltia : Loricariidae, IPeckoltia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peckoltia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52089;

    /// <inheritdoc />
    public virtual string GenusName => "Peckoltia";

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
