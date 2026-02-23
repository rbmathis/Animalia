using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Atlapetes;

/// <summary>
/// Abstract class for Atlapetes (genus).
/// NCBI TaxId: 65358
/// </summary>
public abstract class Atlapetes : Passerellidae, IAtlapetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atlapetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 65358;

    /// <inheritdoc />
    public virtual string GenusName => "Atlapetes";

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
