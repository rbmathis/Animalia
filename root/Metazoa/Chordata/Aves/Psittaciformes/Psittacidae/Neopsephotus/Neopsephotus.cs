using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Neopsephotus;

/// <summary>
/// Abstract class for Neopsephotus (genus).
/// NCBI TaxId: 309877
/// </summary>
public abstract class Neopsephotus : Psittacidae, INeopsephotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neopsephotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 309877;

    /// <inheritdoc />
    public virtual string GenusName => "Neopsephotus";

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
