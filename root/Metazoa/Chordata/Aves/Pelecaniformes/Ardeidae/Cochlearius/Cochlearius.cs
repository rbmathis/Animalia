using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Cochlearius;

/// <summary>
/// Abstract class for Cochlearius (genus).
/// NCBI TaxId: 110675
/// </summary>
public abstract class Cochlearius : Ardeidae, ICochlearius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cochlearius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110675;

    /// <inheritdoc />
    public virtual string GenusName => "Cochlearius";

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
