using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Paradigalla;

/// <summary>
/// Abstract class for Paradigalla (genus).
/// NCBI TaxId: 681194
/// </summary>
public abstract class Paradigalla : Paradisaeidae, IParadigalla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradigalla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681194;

    /// <inheritdoc />
    public virtual string GenusName => "Paradigalla";

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
