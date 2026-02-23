using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Platysteira;

/// <summary>
/// Abstract class for Platysteira (genus).
/// NCBI TaxId: 107225
/// </summary>
public abstract class Platysteira : Passeriformes, IPlatysteira
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platysteira";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107225;

    /// <inheritdoc />
    public virtual string GenusName => "Platysteira";

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
