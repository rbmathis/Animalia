using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae.Narcinops;

/// <summary>
/// Abstract class for Narcinops (genus).
/// NCBI TaxId: 3139385
/// </summary>
public abstract class Narcinops : Narcinidae, INarcinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Narcinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3139385;

    /// <inheritdoc />
    public virtual string GenusName => "Narcinops";

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
