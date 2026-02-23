using AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Nothoprocta;

/// <summary>
/// Abstract class for Nothoprocta (genus).
/// NCBI TaxId: 8806
/// </summary>
public abstract class Nothoprocta : Tinamidae, INothoprocta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nothoprocta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8806;

    /// <inheritdoc />
    public virtual string GenusName => "Nothoprocta";

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
