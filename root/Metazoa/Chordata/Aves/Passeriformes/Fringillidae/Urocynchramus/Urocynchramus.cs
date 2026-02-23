using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Urocynchramus;

/// <summary>
/// Abstract class for Urocynchramus (genus).
/// NCBI TaxId: 571889
/// </summary>
public abstract class Urocynchramus : Fringillidae, IUrocynchramus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urocynchramus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 571889;

    /// <inheritdoc />
    public virtual string GenusName => "Urocynchramus";

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
