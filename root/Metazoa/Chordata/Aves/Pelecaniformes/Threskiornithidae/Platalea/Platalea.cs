using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Platalea;

/// <summary>
/// Abstract class for Platalea (genus).
/// NCBI TaxId: 33577
/// </summary>
public abstract class Platalea : Threskiornithidae, IPlatalea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platalea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33577;

    /// <inheritdoc />
    public virtual string GenusName => "Platalea";

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
