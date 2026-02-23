using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Heterocercus;

/// <summary>
/// Abstract class for Heterocercus (genus).
/// NCBI TaxId: 415021
/// </summary>
public abstract class Heterocercus : Pipridae, IHeterocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 415021;

    /// <inheritdoc />
    public virtual string GenusName => "Heterocercus";

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
