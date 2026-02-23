using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Ocyphaps;

/// <summary>
/// Abstract class for Ocyphaps (genus).
/// NCBI TaxId: 187127
/// </summary>
public abstract class Ocyphaps : Columbidae, IOcyphaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ocyphaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187127;

    /// <inheritdoc />
    public virtual string GenusName => "Ocyphaps";

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
