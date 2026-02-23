using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Phimosus;

/// <summary>
/// Abstract class for Phimosus (genus).
/// NCBI TaxId: 555322
/// </summary>
public abstract class Phimosus : Threskiornithidae, IPhimosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phimosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555322;

    /// <inheritdoc />
    public virtual string GenusName => "Phimosus";

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
