using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Conuropsis;

/// <summary>
/// Abstract class for Conuropsis (genus).
/// NCBI TaxId: 867393
/// </summary>
public abstract class Conuropsis : Psittacidae, IConuropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conuropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 867393;

    /// <inheritdoc />
    public virtual string GenusName => "Conuropsis";

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
