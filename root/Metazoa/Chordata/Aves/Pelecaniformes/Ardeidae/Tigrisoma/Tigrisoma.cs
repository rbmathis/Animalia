using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Tigrisoma;

/// <summary>
/// Abstract class for Tigrisoma (genus).
/// NCBI TaxId: 110693
/// </summary>
public abstract class Tigrisoma : Ardeidae, ITigrisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tigrisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110693;

    /// <inheritdoc />
    public virtual string GenusName => "Tigrisoma";

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
