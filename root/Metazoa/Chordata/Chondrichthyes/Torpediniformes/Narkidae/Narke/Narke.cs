using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narkidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narkidae.Narke;

/// <summary>
/// Abstract class for Narke (genus).
/// NCBI TaxId: 62964
/// </summary>
public abstract class Narke : Narkidae, INarke
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Narke";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62964;

    /// <inheritdoc />
    public virtual string GenusName => "Narke";

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
