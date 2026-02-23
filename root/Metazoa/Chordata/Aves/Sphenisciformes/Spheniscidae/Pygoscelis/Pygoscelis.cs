using AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Pygoscelis;

/// <summary>
/// Abstract class for Pygoscelis (genus).
/// NCBI TaxId: 9237
/// </summary>
public abstract class Pygoscelis : Spheniscidae, IPygoscelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygoscelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9237;

    /// <inheritdoc />
    public virtual string GenusName => "Pygoscelis";

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
