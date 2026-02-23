using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Irania;

/// <summary>
/// Abstract class for Irania (genus).
/// NCBI TaxId: 758446
/// </summary>
public abstract class Irania : Muscicapidae, IIrania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Irania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 758446;

    /// <inheritdoc />
    public virtual string GenusName => "Irania";

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
