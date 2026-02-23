using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Eclectus;

/// <summary>
/// Abstract class for Eclectus (genus).
/// NCBI TaxId: 176023
/// </summary>
public abstract class Eclectus : Psittacidae, IEclectus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eclectus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176023;

    /// <inheritdoc />
    public virtual string GenusName => "Eclectus";

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
