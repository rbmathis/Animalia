using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Chrysothlypis;

/// <summary>
/// Abstract class for Chrysothlypis (genus).
/// NCBI TaxId: 62174
/// </summary>
public abstract class Chrysothlypis : Thraupidae, IChrysothlypis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysothlypis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62174;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysothlypis";

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
