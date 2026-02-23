using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Amblyraja;

/// <summary>
/// Abstract class for Amblyraja (genus).
/// NCBI TaxId: 117853
/// </summary>
public abstract class Amblyraja : Rajidae, IAmblyraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117853;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyraja";

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
