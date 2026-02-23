using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Eremopterix;

/// <summary>
/// Abstract class for Eremopterix (genus).
/// NCBI TaxId: 72218
/// </summary>
public abstract class Eremopterix : Alaudidae, IEremopterix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremopterix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72218;

    /// <inheritdoc />
    public virtual string GenusName => "Eremopterix";

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
