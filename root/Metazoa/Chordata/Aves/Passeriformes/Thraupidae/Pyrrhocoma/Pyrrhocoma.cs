using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Pyrrhocoma;

/// <summary>
/// Abstract class for Pyrrhocoma (genus).
/// NCBI TaxId: 62238
/// </summary>
public abstract class Pyrrhocoma : Thraupidae, IPyrrhocoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrrhocoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62238;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrrhocoma";

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
