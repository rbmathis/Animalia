using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Terpsiphone;

/// <summary>
/// Abstract class for Terpsiphone (genus).
/// NCBI TaxId: 98151
/// </summary>
public abstract class Terpsiphone : Monarchidae, ITerpsiphone
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Terpsiphone";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98151;

    /// <inheritdoc />
    public virtual string GenusName => "Terpsiphone";

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
