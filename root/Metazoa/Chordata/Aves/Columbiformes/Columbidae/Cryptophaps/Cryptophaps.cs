using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Cryptophaps;

/// <summary>
/// Abstract class for Cryptophaps (genus).
/// NCBI TaxId: 2953379
/// </summary>
public abstract class Cryptophaps : Columbidae, ICryptophaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptophaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2953379;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptophaps";

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
