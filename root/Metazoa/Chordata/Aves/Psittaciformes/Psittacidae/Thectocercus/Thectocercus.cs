using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Thectocercus;

/// <summary>
/// Abstract class for Thectocercus (genus).
/// NCBI TaxId: 2823206
/// </summary>
public abstract class Thectocercus : Psittacidae, IThectocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thectocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823206;

    /// <inheritdoc />
    public virtual string GenusName => "Thectocercus";

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
