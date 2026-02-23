using AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Eptatretus;

/// <summary>
/// Abstract class for Eptatretus (genus).
/// NCBI TaxId: 7763
/// </summary>
public abstract class Eptatretus : Myxinidae, IEptatretus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eptatretus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7763;

    /// <inheritdoc />
    public virtual string GenusName => "Eptatretus";

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
