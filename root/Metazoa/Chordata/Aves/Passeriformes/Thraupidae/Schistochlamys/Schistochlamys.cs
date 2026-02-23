using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Schistochlamys;

/// <summary>
/// Abstract class for Schistochlamys (genus).
/// NCBI TaxId: 62241
/// </summary>
public abstract class Schistochlamys : Thraupidae, ISchistochlamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schistochlamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62241;

    /// <inheritdoc />
    public virtual string GenusName => "Schistochlamys";

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
