using AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Eudromia;

/// <summary>
/// Abstract class for Eudromia (genus).
/// NCBI TaxId: 8804
/// </summary>
public abstract class Eudromia : Tinamidae, IEudromia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eudromia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8804;

    /// <inheritdoc />
    public virtual string GenusName => "Eudromia";

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
