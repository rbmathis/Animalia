using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Eudocimus;

/// <summary>
/// Abstract class for Eudocimus (genus).
/// NCBI TaxId: 335482
/// </summary>
public abstract class Eudocimus : Threskiornithidae, IEudocimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eudocimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 335482;

    /// <inheritdoc />
    public virtual string GenusName => "Eudocimus";

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
