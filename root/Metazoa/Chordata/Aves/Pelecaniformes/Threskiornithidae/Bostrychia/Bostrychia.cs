using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Bostrychia;

/// <summary>
/// Abstract class for Bostrychia (genus).
/// NCBI TaxId: 1281446
/// </summary>
public abstract class Bostrychia : Threskiornithidae, IBostrychia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bostrychia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1281446;

    /// <inheritdoc />
    public virtual string GenusName => "Bostrychia";

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
