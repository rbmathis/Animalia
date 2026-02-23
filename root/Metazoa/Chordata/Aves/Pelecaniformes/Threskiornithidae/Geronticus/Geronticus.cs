using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Geronticus;

/// <summary>
/// Abstract class for Geronticus (genus).
/// NCBI TaxId: 100820
/// </summary>
public abstract class Geronticus : Threskiornithidae, IGeronticus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geronticus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100820;

    /// <inheritdoc />
    public virtual string GenusName => "Geronticus";

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
