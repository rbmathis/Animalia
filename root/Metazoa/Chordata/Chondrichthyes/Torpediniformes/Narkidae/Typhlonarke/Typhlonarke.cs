using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narkidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narkidae.Typhlonarke;

/// <summary>
/// Abstract class for Typhlonarke (genus).
/// NCBI TaxId: 1072513
/// </summary>
public abstract class Typhlonarke : Narkidae, ITyphlonarke
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlonarke";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1072513;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlonarke";

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
