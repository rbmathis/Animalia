using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Coracopsis;

/// <summary>
/// Abstract class for Coracopsis (genus).
/// NCBI TaxId: 176021
/// </summary>
public abstract class Coracopsis : Psittacidae, ICoracopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coracopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176021;

    /// <inheritdoc />
    public virtual string GenusName => "Coracopsis";

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
