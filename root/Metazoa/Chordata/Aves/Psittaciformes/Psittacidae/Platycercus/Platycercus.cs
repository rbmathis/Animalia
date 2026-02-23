using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Platycercus;

/// <summary>
/// Abstract class for Platycercus (genus).
/// NCBI TaxId: 35541
/// </summary>
public abstract class Platycercus : Psittacidae, IPlatycercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platycercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 35541;

    /// <inheritdoc />
    public virtual string GenusName => "Platycercus";

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
