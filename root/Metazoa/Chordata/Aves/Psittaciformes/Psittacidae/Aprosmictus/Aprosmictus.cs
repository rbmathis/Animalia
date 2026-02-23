using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Aprosmictus;

/// <summary>
/// Abstract class for Aprosmictus (genus).
/// NCBI TaxId: 274067
/// </summary>
public abstract class Aprosmictus : Psittacidae, IAprosmictus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aprosmictus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274067;

    /// <inheritdoc />
    public virtual string GenusName => "Aprosmictus";

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
