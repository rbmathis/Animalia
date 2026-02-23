using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Northiella;

/// <summary>
/// Abstract class for Northiella (genus).
/// NCBI TaxId: 504064
/// </summary>
public abstract class Northiella : Psittacidae, INorthiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Northiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 504064;

    /// <inheritdoc />
    public virtual string GenusName => "Northiella";

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
