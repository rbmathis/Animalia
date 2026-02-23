using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pseudobias;

/// <summary>
/// Abstract class for Pseudobias (genus).
/// NCBI TaxId: 272847
/// </summary>
public abstract class Pseudobias : Passeriformes, IPseudobias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272847;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobias";

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
