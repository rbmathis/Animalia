using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Nymphicus;

/// <summary>
/// Abstract class for Nymphicus (genus).
/// NCBI TaxId: 13179
/// </summary>
public abstract class Nymphicus : Cacatuidae, INymphicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nymphicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13179;

    /// <inheritdoc />
    public virtual string GenusName => "Nymphicus";

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
