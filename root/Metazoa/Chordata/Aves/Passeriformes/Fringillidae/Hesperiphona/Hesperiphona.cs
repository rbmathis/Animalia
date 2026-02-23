using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Hesperiphona;

/// <summary>
/// Abstract class for Hesperiphona (genus).
/// NCBI TaxId: 670342
/// </summary>
public abstract class Hesperiphona : Fringillidae, IHesperiphona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hesperiphona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 670342;

    /// <inheritdoc />
    public virtual string GenusName => "Hesperiphona";

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
