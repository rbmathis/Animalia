using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Orectolobidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Orectolobidae.Sutorectus;

/// <summary>
/// Abstract class for Sutorectus (genus).
/// NCBI TaxId: 496410
/// </summary>
public abstract class Sutorectus : Orectolobidae, ISutorectus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sutorectus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 496410;

    /// <inheritdoc />
    public virtual string GenusName => "Sutorectus";

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
