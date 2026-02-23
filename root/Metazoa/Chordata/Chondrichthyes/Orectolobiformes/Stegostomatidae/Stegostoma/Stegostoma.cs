using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Stegostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Stegostomatidae.Stegostoma;

/// <summary>
/// Abstract class for Stegostoma (genus).
/// NCBI TaxId: 378070
/// </summary>
public abstract class Stegostoma : Stegostomatidae, IStegostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stegostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 378070;

    /// <inheritdoc />
    public virtual string GenusName => "Stegostoma";

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
