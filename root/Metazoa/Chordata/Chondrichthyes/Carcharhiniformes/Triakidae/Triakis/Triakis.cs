using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Triakis;

/// <summary>
/// Abstract class for Triakis (genus).
/// NCBI TaxId: 7840
/// </summary>
public abstract class Triakis : Triakidae, ITriakis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triakis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7840;

    /// <inheritdoc />
    public virtual string GenusName => "Triakis";

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
