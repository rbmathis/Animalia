using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Phaps;

/// <summary>
/// Abstract class for Phaps (genus).
/// NCBI TaxId: 115694
/// </summary>
public abstract class Phaps : Columbidae, IPhaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115694;

    /// <inheritdoc />
    public virtual string GenusName => "Phaps";

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
