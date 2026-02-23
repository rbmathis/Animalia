using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Alisterus;

/// <summary>
/// Abstract class for Alisterus (genus).
/// NCBI TaxId: 309869
/// </summary>
public abstract class Alisterus : Psittacidae, IAlisterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alisterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 309869;

    /// <inheritdoc />
    public virtual string GenusName => "Alisterus";

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
