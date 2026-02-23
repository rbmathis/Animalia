using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Wetmorethraupis;

/// <summary>
/// Abstract class for Wetmorethraupis (genus).
/// NCBI TaxId: 548521
/// </summary>
public abstract class Wetmorethraupis : Thraupidae, IWetmorethraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wetmorethraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 548521;

    /// <inheritdoc />
    public virtual string GenusName => "Wetmorethraupis";

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
