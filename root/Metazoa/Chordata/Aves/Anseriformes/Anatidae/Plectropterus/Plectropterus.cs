using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Plectropterus;

/// <summary>
/// Abstract class for Plectropterus (genus).
/// NCBI TaxId: 658923
/// </summary>
public abstract class Plectropterus : Anatidae, IPlectropterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectropterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 658923;

    /// <inheritdoc />
    public virtual string GenusName => "Plectropterus";

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
