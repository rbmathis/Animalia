using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Ginglymostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Ginglymostomatidae.Nebrius;

/// <summary>
/// Abstract class for Nebrius (genus).
/// NCBI TaxId: 496404
/// </summary>
public abstract class Nebrius : Ginglymostomatidae, INebrius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nebrius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 496404;

    /// <inheritdoc />
    public virtual string GenusName => "Nebrius";

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
