using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Anthus;

/// <summary>
/// Abstract class for Anthus (genus).
/// NCBI TaxId: 36257
/// </summary>
public abstract class Anthus : Motacillidae, IAnthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36257;

    /// <inheritdoc />
    public virtual string GenusName => "Anthus";

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
