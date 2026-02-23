using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Nucifraga;

/// <summary>
/// Abstract class for Nucifraga (genus).
/// NCBI TaxId: 56785
/// </summary>
public abstract class Nucifraga : Corvidae, INucifraga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nucifraga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56785;

    /// <inheritdoc />
    public virtual string GenusName => "Nucifraga";

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
