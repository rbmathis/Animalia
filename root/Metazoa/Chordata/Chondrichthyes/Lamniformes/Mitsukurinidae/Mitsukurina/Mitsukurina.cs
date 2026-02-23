using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Mitsukurinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Mitsukurinidae.Mitsukurina;

/// <summary>
/// Abstract class for Mitsukurina (genus).
/// NCBI TaxId: 57986
/// </summary>
public abstract class Mitsukurina : Mitsukurinidae, IMitsukurina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mitsukurina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57986;

    /// <inheritdoc />
    public virtual string GenusName => "Mitsukurina";

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
