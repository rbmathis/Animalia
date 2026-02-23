using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Buthraupis;

/// <summary>
/// Abstract class for Buthraupis (genus).
/// NCBI TaxId: 62158
/// </summary>
public abstract class Buthraupis : Thraupidae, IButhraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Buthraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62158;

    /// <inheritdoc />
    public virtual string GenusName => "Buthraupis";

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
