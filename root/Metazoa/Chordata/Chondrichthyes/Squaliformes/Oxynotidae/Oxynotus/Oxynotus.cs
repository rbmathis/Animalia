using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Oxynotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Oxynotidae.Oxynotus;

/// <summary>
/// Abstract class for Oxynotus (genus).
/// NCBI TaxId: 862899
/// </summary>
public abstract class Oxynotus : Oxynotidae, IOxynotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxynotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862899;

    /// <inheritdoc />
    public virtual string GenusName => "Oxynotus";

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
