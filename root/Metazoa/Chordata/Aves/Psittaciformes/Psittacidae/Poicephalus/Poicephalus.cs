using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Poicephalus;

/// <summary>
/// Abstract class for Poicephalus (genus).
/// NCBI TaxId: 176044
/// </summary>
public abstract class Poicephalus : Psittacidae, IPoicephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poicephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176044;

    /// <inheritdoc />
    public virtual string GenusName => "Poicephalus";

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
