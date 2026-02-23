using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Rowettia;

/// <summary>
/// Abstract class for Rowettia (genus).
/// NCBI TaxId: 410741
/// </summary>
public abstract class Rowettia : Fringillidae, IRowettia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rowettia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 410741;

    /// <inheritdoc />
    public virtual string GenusName => "Rowettia";

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
