using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Rhynchopsitta;

/// <summary>
/// Abstract class for Rhynchopsitta (genus).
/// NCBI TaxId: 309840
/// </summary>
public abstract class Rhynchopsitta : Psittacidae, IRhynchopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 309840;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchopsitta";

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
