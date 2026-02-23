using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Treron;

/// <summary>
/// Abstract class for Treron (genus).
/// NCBI TaxId: 115701
/// </summary>
public abstract class Treron : Columbidae, ITreron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Treron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115701;

    /// <inheritdoc />
    public virtual string GenusName => "Treron";

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
