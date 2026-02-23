using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Grandala;

/// <summary>
/// Abstract class for Grandala (genus).
/// NCBI TaxId: 1463980
/// </summary>
public abstract class Grandala : Muscicapidae, IGrandala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grandala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463980;

    /// <inheritdoc />
    public virtual string GenusName => "Grandala";

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
