using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Heliothraupis;

/// <summary>
/// Abstract class for Heliothraupis (genus).
/// NCBI TaxId: 2902953
/// </summary>
public abstract class Heliothraupis : Thraupidae, IHeliothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2902953;

    /// <inheritdoc />
    public virtual string GenusName => "Heliothraupis";

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
