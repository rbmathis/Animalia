using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Purpureicephalus;

/// <summary>
/// Abstract class for Purpureicephalus (genus).
/// NCBI TaxId: 336386
/// </summary>
public abstract class Purpureicephalus : Psittacidae, IPurpureicephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Purpureicephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 336386;

    /// <inheritdoc />
    public virtual string GenusName => "Purpureicephalus";

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
