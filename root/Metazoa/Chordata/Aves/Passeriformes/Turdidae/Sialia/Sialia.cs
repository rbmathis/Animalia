using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Sialia;

/// <summary>
/// Abstract class for Sialia (genus).
/// NCBI TaxId: 172412
/// </summary>
public abstract class Sialia : Turdidae, ISialia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sialia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172412;

    /// <inheritdoc />
    public virtual string GenusName => "Sialia";

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
