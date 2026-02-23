using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Theristicus;

/// <summary>
/// Abstract class for Theristicus (genus).
/// NCBI TaxId: 399596
/// </summary>
public abstract class Theristicus : Threskiornithidae, ITheristicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Theristicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 399596;

    /// <inheritdoc />
    public virtual string GenusName => "Theristicus";

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
