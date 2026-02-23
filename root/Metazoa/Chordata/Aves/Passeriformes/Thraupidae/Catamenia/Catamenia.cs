using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Catamenia;

/// <summary>
/// Abstract class for Catamenia (genus).
/// NCBI TaxId: 138963
/// </summary>
public abstract class Catamenia : Thraupidae, ICatamenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catamenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 138963;

    /// <inheritdoc />
    public virtual string GenusName => "Catamenia";

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
