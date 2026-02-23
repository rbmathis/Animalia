using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Hypnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Hypnidae.Hypnos;

/// <summary>
/// Abstract class for Hypnos (genus).
/// NCBI TaxId: 117890
/// </summary>
public abstract class Hypnos : Hypnidae, IHypnos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypnos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117890;

    /// <inheritdoc />
    public virtual string GenusName => "Hypnos";

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
