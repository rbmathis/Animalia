using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Rajella;

/// <summary>
/// Abstract class for Rajella (genus).
/// NCBI TaxId: 117865
/// </summary>
public abstract class Rajella : Rajidae, IRajella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rajella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117865;

    /// <inheritdoc />
    public virtual string GenusName => "Rajella";

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
